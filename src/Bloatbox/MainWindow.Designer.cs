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
            this.BtnRemoveUWP = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.LstUWPRemove = new System.Windows.Forms.ListBox();
            this.LstUWP = new System.Windows.Forms.ListBox();
            this.PnlLeft = new System.Windows.Forms.Panel();
            this.LbllName = new System.Windows.Forms.Label();
            this.LblMainMenu = new System.Windows.Forms.Button();
            this.PnlRight = new System.Windows.Forms.Panel();
            this.LblrName = new System.Windows.Forms.Label();
            this.PnlMiddle = new System.Windows.Forms.Panel();
            this.PBar = new System.Windows.Forms.ProgressBar();
            this.LblHeader = new System.Windows.Forms.Label();
            this.LnkGetCommunityVer = new System.Windows.Forms.LinkLabel();
            this.LblsAction = new System.Windows.Forms.Label();
            this.MainMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LinkGitHub = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.AppInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlLeft.SuspendLayout();
            this.PnlRight.SuspendLayout();
            this.PnlMiddle.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChkShowUWPSystem
            // 
            this.ChkShowUWPSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChkShowUWPSystem.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChkShowUWPSystem.AutoSize = true;
            this.ChkShowUWPSystem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ChkShowUWPSystem.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.ChkShowUWPSystem.FlatAppearance.BorderSize = 0;
            this.ChkShowUWPSystem.FlatAppearance.CheckedBackColor = System.Drawing.Color.HotPink;
            this.ChkShowUWPSystem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.ChkShowUWPSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChkShowUWPSystem.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkShowUWPSystem.Location = new System.Drawing.Point(15, 710);
            this.ChkShowUWPSystem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChkShowUWPSystem.Name = "ChkShowUWPSystem";
            this.ChkShowUWPSystem.Size = new System.Drawing.Size(146, 31);
            this.ChkShowUWPSystem.TabIndex = 25;
            this.ChkShowUWPSystem.Text = "Show System apps";
            this.ChkShowUWPSystem.UseVisualStyleBackColor = false;
            this.ChkShowUWPSystem.CheckedChanged += new System.EventHandler(this.ChkShowUWPSystem_CheckedChanged);
            // 
            // LblInstalledCount
            // 
            this.LblInstalledCount.AutoSize = true;
            this.LblInstalledCount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInstalledCount.ForeColor = System.Drawing.Color.DeepPink;
            this.LblInstalledCount.Location = new System.Drawing.Point(12, 54);
            this.LblInstalledCount.Name = "LblInstalledCount";
            this.LblInstalledCount.Size = new System.Drawing.Size(95, 30);
            this.LblInstalledCount.TabIndex = 24;
            this.LblInstalledCount.Text = "Apps [0] ";
            // 
            // LblRemoveCount
            // 
            this.LblRemoveCount.AutoSize = true;
            this.LblRemoveCount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRemoveCount.ForeColor = System.Drawing.Color.DeepPink;
            this.LblRemoveCount.Location = new System.Drawing.Point(12, 54);
            this.LblRemoveCount.Name = "LblRemoveCount";
            this.LblRemoveCount.Size = new System.Drawing.Size(122, 30);
            this.LblRemoveCount.TabIndex = 23;
            this.LblRemoveCount.Text = "Remove [0] ";
            // 
            // BtnRemoveAll
            // 
            this.BtnRemoveAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRemoveAll.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnRemoveAll.Enabled = false;
            this.BtnRemoveAll.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.BtnRemoveAll.FlatAppearance.BorderSize = 0;
            this.BtnRemoveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemoveAll.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemoveAll.Location = new System.Drawing.Point(19, 276);
            this.BtnRemoveAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnRemoveAll.Name = "BtnRemoveAll";
            this.BtnRemoveAll.Size = new System.Drawing.Size(389, 32);
            this.BtnRemoveAll.TabIndex = 22;
            this.BtnRemoveAll.Text = "<< Remove all";
            this.BtnRemoveAll.UseVisualStyleBackColor = false;
            this.BtnRemoveAll.Click += new System.EventHandler(this.BtnRemoveAll_Click);
            // 
            // BtnAddAll
            // 
            this.BtnAddAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddAll.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnAddAll.Enabled = false;
            this.BtnAddAll.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.BtnAddAll.FlatAppearance.BorderSize = 0;
            this.BtnAddAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddAll.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddAll.Location = new System.Drawing.Point(17, 176);
            this.BtnAddAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAddAll.Name = "BtnAddAll";
            this.BtnAddAll.Size = new System.Drawing.Size(389, 32);
            this.BtnAddAll.TabIndex = 21;
            this.BtnAddAll.Text = "Add all >>";
            this.BtnAddAll.UseVisualStyleBackColor = false;
            this.BtnAddAll.Click += new System.EventHandler(this.BtnAddAll_Click);
            // 
            // BtnRemoveUWP
            // 
            this.BtnRemoveUWP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRemoveUWP.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnRemoveUWP.Enabled = false;
            this.BtnRemoveUWP.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.BtnRemoveUWP.FlatAppearance.BorderSize = 0;
            this.BtnRemoveUWP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemoveUWP.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemoveUWP.Location = new System.Drawing.Point(17, 700);
            this.BtnRemoveUWP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnRemoveUWP.Name = "BtnRemoveUWP";
            this.BtnRemoveUWP.Size = new System.Drawing.Size(389, 32);
            this.BtnRemoveUWP.TabIndex = 20;
            this.BtnRemoveUWP.Text = "Uninstall";
            this.BtnRemoveUWP.UseVisualStyleBackColor = false;
            this.BtnRemoveUWP.Click += new System.EventHandler(this.BtnRemoveUWP_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.AutoSize = true;
            this.BtnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.BtnRefresh.FlatAppearance.BorderSize = 0;
            this.BtnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresh.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefresh.Location = new System.Drawing.Point(317, 46);
            this.BtnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(41, 43);
            this.BtnRefresh.TabIndex = 19;
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnClear.Enabled = false;
            this.BtnClear.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.BtnClear.FlatAppearance.BorderSize = 0;
            this.BtnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(314, 46);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(44, 43);
            this.BtnClear.TabIndex = 18;
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRemove.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnRemove.Enabled = false;
            this.BtnRemove.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.BtnRemove.FlatAppearance.BorderSize = 0;
            this.BtnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemove.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemove.Location = new System.Drawing.Point(19, 316);
            this.BtnRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(389, 32);
            this.BtnRemove.TabIndex = 17;
            this.BtnRemove.Text = "< Remove selected";
            this.BtnRemove.UseVisualStyleBackColor = false;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnAdd.Enabled = false;
            this.BtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(17, 216);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(389, 32);
            this.BtnAdd.TabIndex = 16;
            this.BtnAdd.Text = "Add selected >";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LstUWPRemove
            // 
            this.LstUWPRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LstUWPRemove.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LstUWPRemove.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstUWPRemove.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstUWPRemove.FormattingEnabled = true;
            this.LstUWPRemove.ItemHeight = 21;
            this.LstUWPRemove.Location = new System.Drawing.Point(17, 118);
            this.LstUWPRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LstUWPRemove.Name = "LstUWPRemove";
            this.LstUWPRemove.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LstUWPRemove.Size = new System.Drawing.Size(341, 609);
            this.LstUWPRemove.Sorted = true;
            this.LstUWPRemove.TabIndex = 15;
            this.LstUWPRemove.DoubleClick += new System.EventHandler(this.LstUWPRemove_DoubleClick);
            // 
            // LstUWP
            // 
            this.LstUWP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LstUWP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LstUWP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstUWP.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstUWP.FormattingEnabled = true;
            this.LstUWP.HorizontalScrollbar = true;
            this.LstUWP.ItemHeight = 21;
            this.LstUWP.Location = new System.Drawing.Point(17, 118);
            this.LstUWP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LstUWP.Name = "LstUWP";
            this.LstUWP.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LstUWP.Size = new System.Drawing.Size(341, 588);
            this.LstUWP.Sorted = true;
            this.LstUWP.TabIndex = 14;
            this.LstUWP.DoubleClick += new System.EventHandler(this.LstUWP_DoubleClick);
            // 
            // PnlLeft
            // 
            this.PnlLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PnlLeft.Controls.Add(this.LbllName);
            this.PnlLeft.Controls.Add(this.LblMainMenu);
            this.PnlLeft.Controls.Add(this.ChkShowUWPSystem);
            this.PnlLeft.Controls.Add(this.LstUWP);
            this.PnlLeft.Controls.Add(this.LblInstalledCount);
            this.PnlLeft.Controls.Add(this.BtnRefresh);
            this.PnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlLeft.Location = new System.Drawing.Point(0, 0);
            this.PnlLeft.Name = "PnlLeft";
            this.PnlLeft.Size = new System.Drawing.Size(358, 745);
            this.PnlLeft.TabIndex = 26;
            // 
            // LbllName
            // 
            this.LbllName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbllName.AutoEllipsis = true;
            this.LbllName.AutoSize = true;
            this.LbllName.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbllName.Location = new System.Drawing.Point(16, 101);
            this.LbllName.Name = "LbllName";
            this.LbllName.Size = new System.Drawing.Size(36, 13);
            this.LbllName.TabIndex = 26;
            this.LbllName.Text = "Name";
            // 
            // LblMainMenu
            // 
            this.LblMainMenu.AutoSize = true;
            this.LblMainMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LblMainMenu.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.LblMainMenu.FlatAppearance.BorderSize = 0;
            this.LblMainMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.LblMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblMainMenu.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMainMenu.ForeColor = System.Drawing.Color.Black;
            this.LblMainMenu.Location = new System.Drawing.Point(0, 0);
            this.LblMainMenu.Name = "LblMainMenu";
            this.LblMainMenu.Size = new System.Drawing.Size(48, 51);
            this.LblMainMenu.TabIndex = 22;
            this.LblMainMenu.UseVisualStyleBackColor = false;
            this.LblMainMenu.Click += new System.EventHandler(this.LblMainMenu_Click);
            // 
            // PnlRight
            // 
            this.PnlRight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PnlRight.Controls.Add(this.LblrName);
            this.PnlRight.Controls.Add(this.LstUWPRemove);
            this.PnlRight.Controls.Add(this.LblRemoveCount);
            this.PnlRight.Controls.Add(this.BtnClear);
            this.PnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlRight.Location = new System.Drawing.Point(794, 0);
            this.PnlRight.Name = "PnlRight";
            this.PnlRight.Size = new System.Drawing.Size(358, 745);
            this.PnlRight.TabIndex = 27;
            // 
            // LblrName
            // 
            this.LblrName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblrName.AutoEllipsis = true;
            this.LblrName.AutoSize = true;
            this.LblrName.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblrName.Location = new System.Drawing.Point(14, 101);
            this.LblrName.Name = "LblrName";
            this.LblrName.Size = new System.Drawing.Size(36, 13);
            this.LblrName.TabIndex = 27;
            this.LblrName.Text = "Name";
            // 
            // PnlMiddle
            // 
            this.PnlMiddle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlMiddle.Controls.Add(this.PBar);
            this.PnlMiddle.Controls.Add(this.LblHeader);
            this.PnlMiddle.Controls.Add(this.LnkGetCommunityVer);
            this.PnlMiddle.Controls.Add(this.LblsAction);
            this.PnlMiddle.Controls.Add(this.BtnAddAll);
            this.PnlMiddle.Controls.Add(this.BtnAdd);
            this.PnlMiddle.Controls.Add(this.BtnRemove);
            this.PnlMiddle.Controls.Add(this.BtnRemoveUWP);
            this.PnlMiddle.Controls.Add(this.BtnRemoveAll);
            this.PnlMiddle.Location = new System.Drawing.Point(364, 0);
            this.PnlMiddle.Name = "PnlMiddle";
            this.PnlMiddle.Size = new System.Drawing.Size(424, 745);
            this.PnlMiddle.TabIndex = 28;
            // 
            // PBar
            // 
            this.PBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PBar.Location = new System.Drawing.Point(16, 87);
            this.PBar.Name = "PBar";
            this.PBar.Size = new System.Drawing.Size(370, 5);
            this.PBar.TabIndex = 26;
            this.PBar.Visible = false;
            // 
            // LblHeader
            // 
            this.LblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblHeader.AutoEllipsis = true;
            this.LblHeader.AutoSize = true;
            this.LblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeader.Location = new System.Drawing.Point(12, 21);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(187, 32);
            this.LblHeader.TabIndex = 25;
            this.LblHeader.Text = "Apps && features";
            // 
            // LnkGetCommunityVer
            // 
            this.LnkGetCommunityVer.AutoSize = true;
            this.LnkGetCommunityVer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkGetCommunityVer.LinkColor = System.Drawing.Color.DeepPink;
            this.LnkGetCommunityVer.Location = new System.Drawing.Point(13, 67);
            this.LnkGetCommunityVer.Name = "LnkGetCommunityVer";
            this.LnkGetCommunityVer.Size = new System.Drawing.Size(316, 17);
            this.LnkGetCommunityVer.TabIndex = 24;
            this.LnkGetCommunityVer.TabStop = true;
            this.LnkGetCommunityVer.Text = "Optional features (download the Community version)";
            this.LnkGetCommunityVer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkGetCommunityVer_LinkClicked);
            // 
            // LblsAction
            // 
            this.LblsAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblsAction.AutoEllipsis = true;
            this.LblsAction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblsAction.Location = new System.Drawing.Point(12, 118);
            this.LblsAction.Name = "LblsAction";
            this.LblsAction.Size = new System.Drawing.Size(377, 21);
            this.LblsAction.TabIndex = 23;
            this.LblsAction.Text = "Move the apps you want to uninstall to the right side.";
            // 
            // MainMenu
            // 
            this.MainMenu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LinkGitHub,
            this.CheckUpdates,
            this.AppInfo});
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MainMenu.Size = new System.Drawing.Size(229, 94);
            // 
            // LinkGitHub
            // 
            this.LinkGitHub.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkGitHub.Image = ((System.Drawing.Image)(resources.GetObject("LinkGitHub.Image")));
            this.LinkGitHub.Name = "LinkGitHub";
            this.LinkGitHub.Size = new System.Drawing.Size(228, 30);
            this.LinkGitHub.Text = "github/bloatbox";
            this.LinkGitHub.Click += new System.EventHandler(this.LinkGitHub_Click);
            // 
            // CheckUpdates
            // 
            this.CheckUpdates.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckUpdates.Name = "CheckUpdates";
            this.CheckUpdates.Size = new System.Drawing.Size(228, 30);
            this.CheckUpdates.Text = "Check for updates";
            this.CheckUpdates.Click += new System.EventHandler(this.CheckUpdates_Click);
            // 
            // AppInfo
            // 
            this.AppInfo.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppInfo.Name = "AppInfo";
            this.AppInfo.Size = new System.Drawing.Size(228, 30);
            this.AppInfo.Text = "Info";
            this.AppInfo.Click += new System.EventHandler(this.AppInfo_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1152, 745);
            this.Controls.Add(this.PnlMiddle);
            this.Controls.Add(this.PnlRight);
            this.Controls.Add(this.PnlLeft);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bloatbox";
            this.PnlLeft.ResumeLayout(false);
            this.PnlLeft.PerformLayout();
            this.PnlRight.ResumeLayout(false);
            this.PnlRight.PerformLayout();
            this.PnlMiddle.ResumeLayout(false);
            this.PnlMiddle.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox ChkShowUWPSystem;
        private System.Windows.Forms.Label LblInstalledCount;
        private System.Windows.Forms.Label LblRemoveCount;
        private System.Windows.Forms.Button BtnRemoveAll;
        private System.Windows.Forms.Button BtnAddAll;
        private System.Windows.Forms.Button BtnRemoveUWP;
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
        private System.Windows.Forms.Label LblsAction;
        private System.Windows.Forms.LinkLabel LnkGetCommunityVer;
        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.ContextMenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem LinkGitHub;
        private System.Windows.Forms.ToolStripMenuItem AppInfo;
        private System.Windows.Forms.Label LbllName;
        private System.Windows.Forms.Label LblrName;
        private System.Windows.Forms.ToolStripMenuItem CheckUpdates;
        private System.Windows.Forms.ProgressBar PBar;
    }
}

