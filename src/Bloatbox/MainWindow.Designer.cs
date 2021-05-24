namespace Bloatbox
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.ChkShowUWPSystem = new System.Windows.Forms.CheckBox();
            this.LblInstalledCount = new System.Windows.Forms.Label();
            this.LblRemoveCount = new System.Windows.Forms.Label();
            this.BtnRemoveAll = new System.Windows.Forms.Button();
            this.BtnAddAll = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.LstUWPRemove = new System.Windows.Forms.ListBox();
            this.LstUWP = new System.Windows.Forms.ListBox();
            this.PnlLeft = new System.Windows.Forms.Panel();
            this.LblLeftAppName = new System.Windows.Forms.Label();
            this.LblMainMenu = new System.Windows.Forms.Button();
            this.PnlRight = new System.Windows.Forms.Panel();
            this.LnkStartFresh = new System.Windows.Forms.LinkLabel();
            this.LblRightInfo = new System.Windows.Forms.Label();
            this.LblRightAppName = new System.Windows.Forms.Label();
            this.PnlMiddle = new System.Windows.Forms.Panel();
            this.PBar = new System.Windows.Forms.ProgressBar();
            this.LblHeader = new System.Windows.Forms.Label();
            this.LnkHeader = new System.Windows.Forms.LinkLabel();
            this.BtnMore = new System.Windows.Forms.Button();
            this.BtnRunUninstaller = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LinkGitHub = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckRelease = new System.Windows.Forms.ToolStripMenuItem();
            this.AppInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlBottom = new System.Windows.Forms.Panel();
            this.PSMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OptionalFeatures = new System.Windows.Forms.ToolStripMenuItem();
            this.Marketplace = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlLeft.SuspendLayout();
            this.PnlRight.SuspendLayout();
            this.PnlMiddle.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.PnlBottom.SuspendLayout();
            this.PSMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChkShowUWPSystem
            // 
            resources.ApplyResources(this.ChkShowUWPSystem, "ChkShowUWPSystem");
            this.ChkShowUWPSystem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ChkShowUWPSystem.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.ChkShowUWPSystem.FlatAppearance.BorderSize = 0;
            this.ChkShowUWPSystem.FlatAppearance.CheckedBackColor = System.Drawing.Color.HotPink;
            this.ChkShowUWPSystem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.ChkShowUWPSystem.Name = "ChkShowUWPSystem";
            this.ChkShowUWPSystem.UseVisualStyleBackColor = false;
            this.ChkShowUWPSystem.CheckedChanged += new System.EventHandler(this.ChkShowUWPSystem_CheckedChanged);
            // 
            // LblInstalledCount
            // 
            resources.ApplyResources(this.LblInstalledCount, "LblInstalledCount");
            this.LblInstalledCount.ForeColor = System.Drawing.Color.Black;
            this.LblInstalledCount.Name = "LblInstalledCount";
            // 
            // LblRemoveCount
            // 
            resources.ApplyResources(this.LblRemoveCount, "LblRemoveCount");
            this.LblRemoveCount.ForeColor = System.Drawing.Color.Black;
            this.LblRemoveCount.Name = "LblRemoveCount";
            // 
            // BtnRemoveAll
            // 
            resources.ApplyResources(this.BtnRemoveAll, "BtnRemoveAll");
            this.BtnRemoveAll.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnRemoveAll.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.BtnRemoveAll.FlatAppearance.BorderSize = 0;
            this.BtnRemoveAll.Name = "BtnRemoveAll";
            this.BtnRemoveAll.UseVisualStyleBackColor = false;
            this.BtnRemoveAll.Click += new System.EventHandler(this.BtnRemoveAll_Click);
            // 
            // BtnAddAll
            // 
            resources.ApplyResources(this.BtnAddAll, "BtnAddAll");
            this.BtnAddAll.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnAddAll.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.BtnAddAll.FlatAppearance.BorderSize = 0;
            this.BtnAddAll.Name = "BtnAddAll";
            this.BtnAddAll.UseVisualStyleBackColor = false;
            this.BtnAddAll.Click += new System.EventHandler(this.BtnAddAll_Click);
            // 
            // BtnRefresh
            // 
            resources.ApplyResources(this.BtnRefresh, "BtnRefresh");
            this.BtnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnRefresh.FlatAppearance.BorderSize = 0;
            this.BtnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnClear
            // 
            resources.ApplyResources(this.BtnClear, "BtnClear");
            this.BtnClear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnClear.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnClear.FlatAppearance.BorderSize = 0;
            this.BtnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnRemove
            // 
            resources.ApplyResources(this.BtnRemove, "BtnRemove");
            this.BtnRemove.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnRemove.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.BtnRemove.FlatAppearance.BorderSize = 0;
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.UseVisualStyleBackColor = false;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnAdd
            // 
            resources.ApplyResources(this.BtnAdd, "BtnAdd");
            this.BtnAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LstUWPRemove
            // 
            resources.ApplyResources(this.LstUWPRemove, "LstUWPRemove");
            this.LstUWPRemove.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LstUWPRemove.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstUWPRemove.FormattingEnabled = true;
            this.LstUWPRemove.Name = "LstUWPRemove";
            this.LstUWPRemove.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LstUWPRemove.Sorted = true;
            this.LstUWPRemove.DoubleClick += new System.EventHandler(this.LstUWPRemove_DoubleClick);
            // 
            // LstUWP
            // 
            resources.ApplyResources(this.LstUWP, "LstUWP");
            this.LstUWP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LstUWP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstUWP.FormattingEnabled = true;
            this.LstUWP.Name = "LstUWP";
            this.LstUWP.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LstUWP.Sorted = true;
            this.LstUWP.DoubleClick += new System.EventHandler(this.LstUWP_DoubleClick);
            // 
            // PnlLeft
            // 
            this.PnlLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PnlLeft.Controls.Add(this.LblLeftAppName);
            this.PnlLeft.Controls.Add(this.LblMainMenu);
            this.PnlLeft.Controls.Add(this.ChkShowUWPSystem);
            this.PnlLeft.Controls.Add(this.LstUWP);
            this.PnlLeft.Controls.Add(this.LblInstalledCount);
            this.PnlLeft.Controls.Add(this.BtnRefresh);
            resources.ApplyResources(this.PnlLeft, "PnlLeft");
            this.PnlLeft.Name = "PnlLeft";
            // 
            // LblLeftAppName
            // 
            resources.ApplyResources(this.LblLeftAppName, "LblLeftAppName");
            this.LblLeftAppName.AutoEllipsis = true;
            this.LblLeftAppName.Name = "LblLeftAppName";
            // 
            // LblMainMenu
            // 
            resources.ApplyResources(this.LblMainMenu, "LblMainMenu");
            this.LblMainMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LblMainMenu.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.LblMainMenu.FlatAppearance.BorderSize = 0;
            this.LblMainMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.LblMainMenu.ForeColor = System.Drawing.Color.Black;
            this.LblMainMenu.Name = "LblMainMenu";
            this.LblMainMenu.UseVisualStyleBackColor = false;
            this.LblMainMenu.Click += new System.EventHandler(this.LblMainMenu_Click);
            // 
            // PnlRight
            // 
            this.PnlRight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PnlRight.Controls.Add(this.LnkStartFresh);
            this.PnlRight.Controls.Add(this.LblRightInfo);
            this.PnlRight.Controls.Add(this.LblRightAppName);
            this.PnlRight.Controls.Add(this.LblRemoveCount);
            this.PnlRight.Controls.Add(this.BtnClear);
            this.PnlRight.Controls.Add(this.LstUWPRemove);
            resources.ApplyResources(this.PnlRight, "PnlRight");
            this.PnlRight.Name = "PnlRight";
            // 
            // LnkStartFresh
            // 
            this.LnkStartFresh.ActiveLinkColor = System.Drawing.Color.MediumVioletRed;
            resources.ApplyResources(this.LnkStartFresh, "LnkStartFresh");
            this.LnkStartFresh.AutoEllipsis = true;
            this.LnkStartFresh.BackColor = System.Drawing.Color.Transparent;
            this.LnkStartFresh.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LnkStartFresh.LinkColor = System.Drawing.Color.DeepPink;
            this.LnkStartFresh.Name = "LnkStartFresh";
            this.LnkStartFresh.TabStop = true;
            this.LnkStartFresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkStartFresh_LinkClicked);
            // 
            // LblRightInfo
            // 
            resources.ApplyResources(this.LblRightInfo, "LblRightInfo");
            this.LblRightInfo.AutoEllipsis = true;
            this.LblRightInfo.Name = "LblRightInfo";
            // 
            // LblRightAppName
            // 
            resources.ApplyResources(this.LblRightAppName, "LblRightAppName");
            this.LblRightAppName.AutoEllipsis = true;
            this.LblRightAppName.Name = "LblRightAppName";
            // 
            // PnlMiddle
            // 
            this.PnlMiddle.Controls.Add(this.PBar);
            this.PnlMiddle.Controls.Add(this.LblHeader);
            this.PnlMiddle.Controls.Add(this.LnkHeader);
            this.PnlMiddle.Controls.Add(this.BtnAddAll);
            this.PnlMiddle.Controls.Add(this.BtnAdd);
            this.PnlMiddle.Controls.Add(this.BtnRemove);
            this.PnlMiddle.Controls.Add(this.BtnRemoveAll);
            this.PnlMiddle.Controls.Add(this.BtnMore);
            resources.ApplyResources(this.PnlMiddle, "PnlMiddle");
            this.PnlMiddle.Name = "PnlMiddle";
            // 
            // PBar
            // 
            resources.ApplyResources(this.PBar, "PBar");
            this.PBar.Name = "PBar";
            // 
            // LblHeader
            // 
            resources.ApplyResources(this.LblHeader, "LblHeader");
            this.LblHeader.AutoEllipsis = true;
            this.LblHeader.Name = "LblHeader";
            // 
            // LnkHeader
            // 
            this.LnkHeader.ActiveLinkColor = System.Drawing.Color.MediumVioletRed;
            resources.ApplyResources(this.LnkHeader, "LnkHeader");
            this.LnkHeader.AutoEllipsis = true;
            this.LnkHeader.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LnkHeader.LinkColor = System.Drawing.Color.DeepPink;
            this.LnkHeader.Name = "LnkHeader";
            this.LnkHeader.TabStop = true;
            this.LnkHeader.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkHeader_LinkClicked);
            // 
            // BtnMore
            // 
            resources.ApplyResources(this.BtnMore, "BtnMore");
            this.BtnMore.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnMore.FlatAppearance.BorderSize = 0;
            this.BtnMore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.BtnMore.Name = "BtnMore";
            this.BtnMore.UseVisualStyleBackColor = true;
            this.BtnMore.Click += new System.EventHandler(this.BtnMore_Click);
            // 
            // BtnRunUninstaller
            // 
            resources.ApplyResources(this.BtnRunUninstaller, "BtnRunUninstaller");
            this.BtnRunUninstaller.BackColor = System.Drawing.Color.LightGray;
            this.BtnRunUninstaller.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.BtnRunUninstaller.FlatAppearance.BorderSize = 0;
            this.BtnRunUninstaller.Name = "BtnRunUninstaller";
            this.BtnRunUninstaller.UseVisualStyleBackColor = false;
            this.BtnRunUninstaller.Click += new System.EventHandler(this.BtnRunUninstaller_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.MainMenu, "MainMenu");
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LinkGitHub,
            this.CheckRelease,
            this.AppInfo});
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // LinkGitHub
            // 
            resources.ApplyResources(this.LinkGitHub, "LinkGitHub");
            this.LinkGitHub.Name = "LinkGitHub";
            this.LinkGitHub.Click += new System.EventHandler(this.LinkGitHub_Click);
            // 
            // CheckRelease
            // 
            resources.ApplyResources(this.CheckRelease, "CheckRelease");
            this.CheckRelease.Name = "CheckRelease";
            this.CheckRelease.Click += new System.EventHandler(this.CheckRelease_Click);
            // 
            // AppInfo
            // 
            resources.ApplyResources(this.AppInfo, "AppInfo");
            this.AppInfo.Name = "AppInfo";
            this.AppInfo.Click += new System.EventHandler(this.AppInfo_Click);
            // 
            // PnlBottom
            // 
            this.PnlBottom.Controls.Add(this.BtnRunUninstaller);
            resources.ApplyResources(this.PnlBottom, "PnlBottom");
            this.PnlBottom.Name = "PnlBottom";
            // 
            // PSMenu
            // 
            this.PSMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.PSMenu, "PSMenu");
            this.PSMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.PSMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptionalFeatures,
            this.Marketplace});
            this.PSMenu.Name = "MainMenu";
            this.PSMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.PSMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.PSMenu_ItemClicked);
            // 
            // OptionalFeatures
            // 
            resources.ApplyResources(this.OptionalFeatures, "OptionalFeatures");
            this.OptionalFeatures.ForeColor = System.Drawing.Color.Black;
            this.OptionalFeatures.Name = "OptionalFeatures";
            // 
            // Marketplace
            // 
            this.Marketplace.Name = "Marketplace";
            resources.ApplyResources(this.Marketplace, "Marketplace");
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PnlBottom);
            this.Controls.Add(this.PnlMiddle);
            this.Controls.Add(this.PnlRight);
            this.Controls.Add(this.PnlLeft);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.PnlLeft.ResumeLayout(false);
            this.PnlLeft.PerformLayout();
            this.PnlRight.ResumeLayout(false);
            this.PnlRight.PerformLayout();
            this.PnlMiddle.ResumeLayout(false);
            this.PnlMiddle.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.PnlBottom.ResumeLayout(false);
            this.PSMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox ChkShowUWPSystem;
        private System.Windows.Forms.Label LblInstalledCount;
        private System.Windows.Forms.Label LblRemoveCount;
        private System.Windows.Forms.Button BtnRemoveAll;
        private System.Windows.Forms.Button BtnAddAll;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.ListBox LstUWPRemove;
        private System.Windows.Forms.ListBox LstUWP;
        private System.Windows.Forms.Panel PnlLeft;
        private System.Windows.Forms.Button LblMainMenu;
        private System.Windows.Forms.Panel PnlRight;
        private System.Windows.Forms.Panel PnlMiddle;
        private System.Windows.Forms.Label LblRightInfo;
        private System.Windows.Forms.LinkLabel LnkHeader;
        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.ContextMenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem LinkGitHub;
        private System.Windows.Forms.ToolStripMenuItem AppInfo;
        private System.Windows.Forms.Label LblLeftAppName;
        private System.Windows.Forms.Label LblRightAppName;
        private System.Windows.Forms.ToolStripMenuItem CheckRelease;
        private System.Windows.Forms.ProgressBar PBar;
        private System.Windows.Forms.LinkLabel LnkStartFresh;
        private System.Windows.Forms.Button BtnRunUninstaller;
        private System.Windows.Forms.Panel PnlBottom;
        private System.Windows.Forms.Button BtnMore;
        private System.Windows.Forms.ContextMenuStrip PSMenu;
        private System.Windows.Forms.ToolStripMenuItem OptionalFeatures;
        private System.Windows.Forms.ToolStripMenuItem Marketplace;
    }
}

