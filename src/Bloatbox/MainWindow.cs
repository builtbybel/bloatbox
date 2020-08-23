using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Bloatbox
{
    public partial class MainWindow : Form
    {
        private readonly string applicationName = Application.ProductName;

        private List<string> _listSystemApps = new List<string>();
        private List<string> _listFreshStart = new List<string>();
        private Config c = new Config();

        private readonly PowerShell powerShell = PowerShell.Create();

        // General strings
        private readonly string _installCount = "My apps";

        private readonly string _removeCount = "Remove apps";
        private readonly string _nothingCount = "No apps to uninstall!";

        private readonly string _warningSystemApps = "Be picky about which System applications to uninstall.\r\n\n" +
                                                     "You can uninstall most of the built-in apps, even ones that don't normally offer an \"Uninstall\" option.\r\n\n" +
                                                     "Note, however, Bloatbox won't allow you to remove a few of the most important built-in apps, like Microsoft Edge, .NET framework, UI.Xaml etc. as these apps are needed for the Windows 10 \"Experience\" and for other programs. " +
                                                     "If you try, you’ll see an error message saying the removal failed.";

        private readonly string _infoFreshStart = "This will add all the annoying bloatware apps, pre-installed on Windows 10 including some apps your PC manufacturer included to the removal list.\r\n\n" +
                                                  "Most of these apps are garbage, but if you find important stuff on the list just remove it from the right box before hitting \"Uninstall\".";

        private readonly string _infoApp = "Bloatbox" + "\nVersion " + Program.GetCurrentVersionTostring() + " (Perseus)" +
                                            "\n\nRemove Bloatwares from Windows 10.\r\n\n" +
                                            "This project was intended as an extension for github.com/builtbybel/privatezilla\r\n\n" +
                                            "You can also reach out to me on\n" +
                                            "\ttwitter.com/builtbybel\r\n\n" +
                                            "(C) 2020, Builtbybel";

        // Community strings
        private readonly string _uriPkg = "https://github.com/Sycnex/Windows10Debloater/raw/master/Windows10Debloater.ps1";

        private readonly string _uriOptionalFeatures = "https://github.com/builtbybel/bloatbox#community-package";
        private readonly string _uriMarketplace= "https://github.com/builtbybel/bloatbox/tree/master/marketplace";

        private readonly string _infoPkg = "This will download the PowerShell based Community version \"Windows10Debloater.ps1\"" +
                                                  "\n\nThis is a interactive script with prompts which runs the following functions:" +
                                                  "\n- Debloat (a list of Bloatware that is removed can be viewed on the authors GitHub repository)" +
                                                  "\n- Removes registry keys leftover that are associated with the bloatware apps" +
                                                  "\n- Protect privacy by stopping some telemetry functions, stops Cortana from being used as your Search Index, disables unneccessary scheduled tasks, and more" +
                                                  "\n- Stop-EdgePDF" +
                                                   "\r\n\nDo you wish to continue?\r\n\nMore information about this script can be found here https://github.com/Sycnex/Windows10Debloater";

        // PowerShell strings
        private readonly string _psInfo = "Disclaimer:\r\n";

        private readonly string _psRun = "Do you really want to run this script?\r\n";

        // Update strings
        private readonly string _releaseURL = "https://raw.githubusercontent.com/builtbybel/patchfluent/master/latest.txt";

        private readonly string _releaseUpToDate = "There are currently no updates available.";
        private readonly string _releaseUnofficial = "You are using an unoffical version of Bloatbox.";

        public Version CurrentVersion = new Version(Application.ProductVersion);
        public Version LatestVersion;

        /// <summary>
        /// Check for updates
        /// </summary>
        private void CheckUpdates_Click(object sender, EventArgs e)
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
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK); // Update check failed!
            }

            var equals = LatestVersion.CompareTo(CurrentVersion);

            if (equals == 0)
            {
                MessageBox.Show(_releaseUpToDate, this.Text, MessageBoxButtons.OK); // Up-to-date
            }
            else if (equals < 0)
            {
                MessageBox.Show(_releaseUnofficial, this.Text, MessageBoxButtons.OK); // Unofficial
            }
            else // New release available!
            {
                if (MessageBox.Show("There is a new version available #" + LatestVersion + "\nYour are using version #" + CurrentVersion + "\n\nDo you want to open the @github/releases page?", this.Text, MessageBoxButtons.YesNo) == DialogResult.Yes) // New release available!
                {
                    Process.Start("https://github.com/builtbybel/bloatbox/releases/tag/" + LatestVersion);
                }
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            GetUWPSystem();   // System apps ONLY
            GetUWP();        // All apps
            GetPS();        // Add community package (optional)

            // GUI options
            // This is using font icons predefined in the fonts of Segoe MDL2 Assets as UWP apps
            LblMainMenu.Text = "\ue700";    // Hamburger menu
            BtnRefresh.Text = "\ue72c";     // Refresh
            BtnMore.Text = "\ue712";        // More menu
            BtnClear.Text = "\ue894";       // Clear
        }

        /// <summary>
        /// Retrieve UWP apps
        /// </summary>
        private void GetUWP()
        {
            LstUWP.Items.Clear();
            powerShell.Commands.Clear();

            powerShell.AddCommand("get-appxpackage");
            powerShell.AddCommand("Select").AddParameter("property", "name"); // Get a list of packages installed for the current user we can run Get-AppxPackage | Format-Wide -Property Name
            // ICollection<PSObject> obj = powerShell.Invoke();

            foreach (PSObject result in powerShell.Invoke())
            {
                string current = result.ToString();
                // Show ONLY NON-SYSTEM apps by comparing found apps with file Bloatbox.txt
                if (_listSystemApps != null) if ((_listSystemApps.Any(current.Contains)) && !ChkShowUWPSystem.Checked) continue;

                if (LstUWP.Items.Contains(Regex.Replace(current, "(@{Name=)|(})", ""))) continue;
                LstUWP.Items.Add(Regex.Replace(current, "(@{Name=)|(})", ""));
            }

            // Compare left and rights apps list and remove differences
            string compare = LstUWP.Items.ToString();
            foreach (string item in LstUWPRemove.Items) if (item.Any(compare.Contains)) LstUWP.Items.Remove(item);

            // Just a re-count!
            RefreshUWP();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            GetUWP();
        }

        /// <summary>
        /// App uninstaller
        /// </summary>
        private string RemoveUWP()
        {
            string success = "Successfully removed:\n";
            string failed = "Failed to remove:\n";

            foreach (var item in LstUWPRemove.Items)
            {
                // Set current removal status in title bar
                this.Text = applicationName + " (Removing " + item.ToString() + ")";

                powerShell.Commands.Clear();
                powerShell.AddCommand("Get-AppxPackage");
                powerShell.AddArgument(item.ToString());
                powerShell.AddCommand("remove-appxpackage");

                List<PSObject> PSOutput = new List<PSObject>(powerShell.Invoke());

                foreach (var p in powerShell.Streams.Progress)
                {
                    if (p.Activity.Contains(item.ToString()) && p.StatusDescription == "Completed")     // Removed successfully
                    {
                        success += "\t" + item.ToString() + "\n";
                        // Console.WriteLine(success + item.ToString());
                        break;
                    }
                    else if (p.Activity.Contains(item.ToString()) && p.StatusDescription == "Error")    // NOT removed
                    {
                        if (!failed.Contains(item.ToString())) failed += "\t" + item.ToString() + "\n";
                        // Console.WriteLine(failed + p.Activity);
                    }
                }

                powerShell.Streams.Progress.Clear();
                /* Detailed log OFF
                if (powerShell.HadErrors) foreach (var p in powerShell.Streams.Error) { Console.WriteLine("\n\nERROR:\n" + p.ToString() + "\n\n"); } */
            }

            // Reset title bar to app name only
            this.Text = applicationName;

            string outputPS;
            if (powerShell.HadErrors) { outputPS = success + "\n" + failed; powerShell.Streams.Error.Clear(); }
            else { outputPS = success; }

            return outputPS;
        }

        private void RefreshUWP()
        {
            int installed = LstUWP.Items.Count;
            int remove = LstUWPRemove.Items.Count;
            LblInstalledCount.Text = _installCount + " (" + installed.ToString() + ")";
            LblRemoveCount.Text = _removeCount + " (" + remove.ToString() + ")";

            if (LstUWPRemove.Items.Count == 0)
            {
                LblrightInfo.Visible = 
                LnkStartFresh.Visible =
       
                true;
            }
            else
            {
                LblrightInfo.Visible =
                LnkStartFresh.Visible =
         
                false;
            }

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
                BtnRunUninstaller.Enabled =
                BtnClear.Enabled =
                false;
            else
                BtnRemoveAll.Enabled =
                BtnRemove.Enabled =
                BtnRunUninstaller.Enabled =
                BtnClear.Enabled =
                true;
        }

        private void ChkShowUWPSystem_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkShowUWPSystem.Checked) MessageBox.Show(_warningSystemApps, "Disclaimer", MessageBoxButtons.OK);
            BtnRefresh_Click(sender, e);
        }

        /// <summary>
        ///  Collect hidden system apps from file
        /// </summary>
        private void GetUWPSystem()
        {
            System.IO.StreamReader Database = null;

            try
            {   //Try to open the file
                Database = System.IO.File.OpenText("bloatbox.txt");
            }
            catch (System.IO.FileNotFoundException)                                       // bloatbox.txt does not exists!?
            {
                System.IO.StreamWriter sw = System.IO.File.CreateText("bloatbox.txt");    // Create it!
                sw.Write(Resources.Bloatbox);                                             // Populate it with built in preset
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
            RefreshUWP();
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
                RefreshUWP();
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
            RefreshUWP();
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
                RefreshUWP();
            }
        }

        /// <summary>
        /// Run the app uninstaller
        /// </summary>
        private void BtnRunUninstaller_Click(object sender, EventArgs e)
        {
            if (LstUWPRemove.Items.Count == 0) { MessageBox.Show(_nothingCount); }
            else
            {
                Enabled = false;

                MessageBox.Show(RemoveUWP());

                LstUWPRemove.Items.Clear();
                BtnRefresh_Click(null, null);
                Enabled = true;
            }
        }

        /// <summary>
        /// Fresh start feature which loads bloatware and crapware from file
        /// </summary>
        private void LnkStartFresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show(_infoFreshStart, this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                string tempPath = Path.GetTempPath() + @"\Bloatbox-Freshstart" + Guid.NewGuid() + ".xml";       // Create a temp FilePath
                StreamWriter sW = new StreamWriter(tempPath, false, Encoding.Unicode);                          // Open a file at the path
                sW.Write(Resources.Freshstart);                                                                 // Load data from resource into tempfile
                sW.Close();                                                                                     // Close the file
                LoadPreset(tempPath);
                File.Delete(tempPath);

                BtnRefresh_Click(null, null);
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
            MessageBox.Show(_infoApp, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Download optional community version Windows10Debloater.ps1
        /// </summary>
        private void LnkGetCommunityVer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show(_infoPkg, this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                PBar.Visible = true;
                var pkg = _uriPkg;

                try
                {
                    WebClient wc = new WebClient();
                    wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressChanged);
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);

                    wc.DownloadFileAsync(new Uri(pkg.Trim()), @"Windows10Debloater.ps1");
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message, this.Text); }
            }
        }

        public void DownloadProgressChanged(Object sender, DownloadProgressChangedEventArgs e)
        {
            PBar.Value = e.ProgressPercentage;
        }

        public void Completed(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                var ps1File = @"Windows10Debloater.ps1";
                var startInfo = new ProcessStartInfo()
                {
                    FileName = "powershell.exe",
                    Arguments = $"-NoProfile -ExecutionPolicy unrestricted -file \"{ps1File}\"",
                    UseShellExecute = true,
                };
                Process.Start(startInfo);
                PBar.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
                PBar.Visible = false;
            }
        }

        private void LoadPreset(string name)
        {
            if (File.Exists(name) == true)
            {
                var serializer = new XmlSerializer(typeof(Config));
                using (var stream = File.OpenRead(name))
                {
                    c = (Config)(serializer.Deserialize(stream));
                }

                _listFreshStart = c.Bloatware;

                LstUWPRemove.Items.Clear();
                foreach (var item in _listFreshStart) LstUWPRemove.Items.Add(item);

                RefreshUWP();
            }
        }

        public class Config
        {
            public List<string> Bloatware
            {
                get;
                set;
            }
        }

        private void BtnMore_Click(object sender, EventArgs e)
        {
            this.PSMenu.Show(Cursor.Position.X, Cursor.Position.Y);
        }

        // Check if ps directory @"scripts" available (optional community feature)
        private void GetPS()
        {
            string path = @"scripts";
            if (Directory.Exists(path)) { PopulatePS(); OptionalFeatures.Visible = false; Marketplace.Visible = true; }
            else
            { OptionalFeatures.Visible = true; Marketplace.Visible = false; }
        }

        /// <summary>
        /// Populate ps files (optional community feature)
        /// </summary>
        private void PopulatePS()
        {
            DirectoryInfo dirs = new DirectoryInfo(@"scripts");
            FileInfo[] listPs = dirs.GetFiles("*.ps1");
            foreach (FileInfo fi in listPs)
            {
                PSMenu.Items.Add(Path.GetFileNameWithoutExtension(fi.Name));
            }
        }

        /// <summary>
        /// Run ps files (optional community feature)
        /// </summary>
        private void PSMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem clickedItem = e.ClickedItem;
            string itemName = clickedItem.Text;

            string psDir = @"scripts\" + itemName + ".ps1";

            if (itemName.Contains("Add more features ..."))
                Process.Start(_uriOptionalFeatures);
            else if (itemName.Contains("Visit Marketplace"))
                Process.Start(_uriMarketplace);
            else
            {
                // Read ps content line by line
                using (StreamReader sr = new StreamReader(psDir, Encoding.Default))
                {
                    // Run ps?
                    if (MessageBox.Show(_psRun + "\r\n" + _psInfo + string.Join(Environment.NewLine, System.IO.File.ReadAllLines(psDir).Where(s => s.StartsWith("###")).Select(s => s.Substring(3).Replace("###", "\r\n"))), "", MessageBoxButtons.YesNo) == DialogResult.Yes)

                    {
                        var ps1File = @"scripts\" + itemName + ".ps1";
                        var startInfo = new ProcessStartInfo()
                        {
                            FileName = "powershell.exe",
                            Arguments = $"-NoProfile -ExecutionPolicy unrestricted -file \"{ps1File}\"",
                            UseShellExecute = true,
                        };
                        Process.Start(startInfo);
                    }
                }
            }
        }
    }
}