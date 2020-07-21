using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Bloatbox
{
    public partial class MainWindow : Form
    {
        private PowerShell powerShell = PowerShell.Create();

        private List<string> _listSystemApps = new List<string>();

        // General strings
        private string _successRemove = "Successfully removed:\n";

        private string _failedRemove = "Failed to remove:\n";
        private readonly string _installCount = "My apps";
        private readonly string _removeCount = "Remove apps";
        private readonly string _nothingCount = "No apps to uninstall!";

        // Update strings
        private readonly string _releaseURL = "https://raw.githubusercontent.com/builtbybel/bloatbox/master/latest.txt";

        private readonly string _releaseUpToDate = "There are currently no updates available.";
        private readonly string _releaseUnofficial = "You are using an unoffical version of Bloatbox.";

        public Version CurrentVersion = new Version(Application.ProductVersion);
        public Version LatestVersion;

        /// <summary>
        /// Check for updates
        /// </summary>
        private void CheckNewReleases_Click(object sender, EventArgs e)
        {
            try
            {
                WebRequest hreq = WebRequest.Create(_releaseURL);
                hreq.Timeout = 10000;
                hreq.Headers.Set("Cache-Control", "no-cache, no-store, must-revalidate");

                WebResponse hres = hreq.GetResponse();
                StreamReader sr = new StreamReader(hres.GetResponseStream());

                LatestVersion = new Version(sr.ReadToEnd().Trim());

                // Done and dispose!
                sr.Dispose();
                hres.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); // Update check failed!
            }

            var equals = LatestVersion.CompareTo(CurrentVersion);

            if (equals == 0)
            {
                MessageBox.Show(_releaseUpToDate, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information); // Up-to-date
            }
            else if (equals < 0)
            {
                MessageBox.Show(_releaseUnofficial, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning); // Unofficial
            }
            else // New release available!
            {
                if (MessageBox.Show("There is a new version available #" + LatestVersion + "\nYour are using version #" + CurrentVersion + "\n\nDo you want to open the @github/releases page?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) // New release available!
                {
                    Process.Start("https://github.com/builtbybel/bloatbox/releases/tag/" + LatestVersion);
                }
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            GetUWPSystem();     // System apps ONLY
            GetUWP();        // All apps

            // GUI options
            LblMainMenu.Text = "\ue700";    // Hamburger menu
            BtnRefresh.Text = "\ue72c";     // Refresh
            BtnClear.Text = "\ue894";       // Clear
        }

        private void GetUWP()
        {
            LstUWP.Items.Clear();
            powerShell.Commands.Clear();

            powerShell.AddCommand("get-appxpackage");
            powerShell.AddCommand("Select").AddParameter("property", "name");
            // ICollection<PSObject> obj = powerShell.Invoke();

            foreach (PSObject result in powerShell.Invoke())
            {
                string current = result.ToString();
                if (_listSystemApps != null) if ((_listSystemApps.Any(current.Contains)) && !ChkShowUWPSystem.Checked) continue;
                if (LstUWP.Items.Contains(Regex.Replace(current, "(@{Name=)|(})", ""))) continue;
                LstUWP.Items.Add(Regex.Replace(current, "(@{Name=)|(})", ""));
            }

            string appInst = LstUWP.Items.ToString();
            foreach (string item in LstUWPRemove.Items) if (item.Any(appInst.Contains)) LstUWP.Items.Remove(item);

            RefreshInstalled();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            GetUWP();
        }

        private string RemoveUWP()
        {
            foreach (var item in LstUWPRemove.Items)
            {
                powerShell.Commands.Clear();
                powerShell.AddCommand("Get-AppxPackage");
                powerShell.AddArgument(item.ToString());
                powerShell.AddCommand("remove-appxpackage");

                List<PSObject> PSOutput = new List<PSObject>(powerShell.Invoke());

                foreach (var p in powerShell.Streams.Progress)
                {
                    if (p.Activity.Contains(item.ToString()) && p.StatusDescription == "Completed")     // Removed successfully
                    {
                        _successRemove += "\t" + item.ToString() + "\n";
                        // Console.WriteLine( _successRemove + item.ToString());
                        break;
                    }
                    else if (p.Activity.Contains(item.ToString()) && p.StatusDescription == "Error")    // NOT removed
                    {
                        if (!_failedRemove.Contains(item.ToString())) _failedRemove += "\t" + item.ToString() + "\n";
                        // Console.WriteLine(_failedRemove + p.Activity);
                    }
                }

                powerShell.Streams.Progress.Clear();

                /* Detailed log OFF!
                if (powerShell.HadErrors) foreach (var p in powerShell.Streams.Error) { Console.WriteLine("\n\nERROR:\n" + p.ToString() + "\n\n"); } */
            }

            string outputPS = "";
            if (powerShell.HadErrors) { outputPS = _successRemove + "\n" + _failedRemove; powerShell.Streams.Error.Clear(); }
            else { outputPS = _successRemove; }

            return outputPS;
        }

        private void RefreshInstalled()
        {
            int installed = LstUWP.Items.Count;
            int remove = LstUWPRemove.Items.Count;
            LblInstalledCount.Text = _installCount + " (" + installed.ToString() + ")";
            LblRemoveCount.Text = _removeCount + " (" + remove.ToString() + ")";

            if (installed == 0)
                BtnAddAll.Enabled =
                BtnAdd.Enabled =
                false;
            else
                BtnAddAll.Enabled =
                BtnAdd.Enabled =
                true;

            if (remove == 0)
                BtnRemoveAll.Enabled =
                BtnRemove.Enabled =
                BtnRemoveUWP.Enabled =
                BtnClear.Enabled =
                false;
            else
                BtnRemoveAll.Enabled =
                BtnRemove.Enabled =
                BtnRemoveUWP.Enabled =
                BtnClear.Enabled =
                true;
        }

        private void ChkShowUWPSystem_CheckedChanged(object sender, EventArgs e)
        {
            GetUWP();
        }

        /// <summary>
        ///  Collect hidden system apps from file
        /// </summary>
        ///
        private void GetUWPSystem()
        {
            System.IO.StreamReader Database = null;

            try
            {   //Try to open the file
                Database = System.IO.File.OpenText("bloatbox.txt");
            }
            catch (System.IO.FileNotFoundException)                                     // bloatbox.txt does not exists!?
            {
                System.IO.StreamWriter sw = System.IO.File.CreateText("bloatbox.txt");    // Create it!
                sw.Write(Resources.bloatbox);                                             // Populate it with built in preset
                sw.Close();

                Database = System.IO.File.OpenText("bloatbox.txt");
            }
            finally
            {
                if (Database.Peek() > 0)                                                // If exists and not empty!
                {
                    string buff;
                    while ((buff = Database.ReadLine()) != null)
                    {
                        _listSystemApps.Add(buff);
                    }
                };
                Database.Close();
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            LstUWPRemove.Items.Clear();
            BtnRefresh_Click(sender, e);
        }

        private void BtnAddAll_Click(object sender, EventArgs e)
        {
            foreach (var item in LstUWP.Items)
            {
                LstUWPRemove.Items.Add(item);
                // LstUWP.Items.Remove(item);
            }
            LstUWP.Items.Clear();
            RefreshInstalled();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (LstUWP.Items.Count != 0)
            {
                if (LstUWP.SelectedItem == null) LstUWP.SelectedIndex = 0;
                while (LstUWP.SelectedItem != null)
                {
                    LstUWPRemove.Items.Add(LstUWP.SelectedItem);
                    LstUWP.Items.Remove(LstUWP.SelectedItem);
                }
                RefreshInstalled();
            }
        }

        private void BtnRemoveAll_Click(object sender, EventArgs e)
        {
            foreach (var item in LstUWPRemove.Items)
            {
                LstUWP.Items.Add(item);
                // LstUWP.Items.Remove(item);
            }
            LstUWPRemove.Items.Clear();
            RefreshInstalled();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (LstUWPRemove.Items.Count != 0)
            {
                if (LstUWPRemove.SelectedItem == null) LstUWPRemove.SelectedIndex = 0;
                while (LstUWPRemove.SelectedItem != null)
                {
                    LstUWP.Items.Add(LstUWPRemove.SelectedItem);
                    LstUWPRemove.Items.Remove(LstUWPRemove.SelectedItem);
                }
                RefreshInstalled();
            }
        }

        private void BtnRemoveUWP_Click(object sender, EventArgs e)
        {
            if (LstUWPRemove.Items.Count == 0) { MessageBox.Show(_nothingCount); }
            else
            {
                Enabled = false;

                MessageBox.Show(RemoveUWP()); // Run app uninstaller!

                LstUWPRemove.Items.Clear();
                BtnRefresh_Click(null, null);
                Enabled = true;
            }
        }

        private void LstUWP_DoubleClick(object sender, EventArgs e)
        {
            BtnAdd_Click(sender, e);
        }

        private void LstUWPRemove_DoubleClick(object sender, EventArgs e)
        {
            BtnRemove_Click(sender, e);
        }

        private void LnkMSSettingsAppsandfeatures_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("ms-settings:appsfeatures");
        }

        private void LblMainMenu_Click(object sender, EventArgs e)
        {
            this.MainMenu.Show(Cursor.Position.X, Cursor.Position.Y);
        }

        private void LinkGitHub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/builtbybel/bloatbox");
        }

        private void AppInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bloatbox" + "\nVersion " + Program.GetCurrentVersionTostring() + " (Perseus)" +
            "\n\nThe alternate Windows 10 app manager.\r\n\n" +
            "This project was intended as an extension for github.com/spydish\r\n\n" +
            "Credits and other notes on github.com/bloatbox\r\n" +
            "(C) 2020, Builtbybel (former Mirinsoft)",
            "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}