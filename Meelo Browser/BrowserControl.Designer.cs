
namespace Meelo_Browser
{
    partial class BrowserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new MetroFramework.Controls.MetroLink();
            this.btnSearch = new MetroFramework.Controls.MetroLink();
            this.optionMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urlField = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureIcon = new System.Windows.Forms.PictureBox();
            this.btnSettings = new MetroFramework.Controls.MetroLink();
            this.btnReload = new MetroFramework.Controls.MetroLink();
            this.btnForward = new MetroFramework.Controls.MetroLink();
            this.btnBack = new MetroFramework.Controls.MetroLink();
            this.historyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new Meelo_Browser.AppData();
            this.browserPanel = new System.Windows.Forms.Panel();
            this.visitPanel = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnMeelo = new Guna.UI2.WinForms.Guna2CircleButton();
            this.htmlTwitter = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.htmlYoutube = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.htmlFacebook = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.htmlGoogle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnTwitter = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnYoutube = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnFacebook = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnGoogle = new Guna.UI2.WinForms.Guna2CircleButton();
            this.historyTableAdapter = new Meelo_Browser.AppDataTableAdapters.historyTableAdapter();
            this.panel1.SuspendLayout();
            this.optionMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            this.browserPanel.SuspendLayout();
            this.visitPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.urlField);
            this.panel1.Controls.Add(this.pictureIcon);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.btnForward);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 37);
            this.panel1.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = global::Meelo_Browser.Properties.Resources.home;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.Location = new System.Drawing.Point(64, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(25, 25);
            this.btnHome.TabIndex = 6;
            this.btnHome.UseSelectable = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.MouseLeave += new System.EventHandler(this.btnHome_MouseLeave);
            this.btnHome.MouseHover += new System.EventHandler(this.btnHome_MouseHover);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackgroundImage = global::Meelo_Browser.Properties.Resources.search_100px;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.ContextMenuStrip = this.optionMenu;
            this.btnSearch.Location = new System.Drawing.Point(832, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(25, 25);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.MouseLeave += new System.EventHandler(this.btnSearch_MouseLeave);
            this.btnSearch.MouseHover += new System.EventHandler(this.btnSearch_MouseHover);
            // 
            // optionMenu
            // 
            this.optionMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyToolStripMenuItem,
            this.pdfViewerToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.optionMenu.Name = "optionMenu";
            this.optionMenu.Size = new System.Drawing.Size(181, 92);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // pdfViewerToolStripMenuItem
            // 
            this.pdfViewerToolStripMenuItem.Name = "pdfViewerToolStripMenuItem";
            this.pdfViewerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.pdfViewerToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.pdfViewerToolStripMenuItem.Text = "Pdf Viewer";
            this.pdfViewerToolStripMenuItem.Click += new System.EventHandler(this.pdfViewerToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // urlField
            // 
            this.urlField.AllowDrop = true;
            this.urlField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlField.Animated = true;
            this.urlField.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.urlField.AutoRoundedCorners = true;
            this.urlField.BackColor = System.Drawing.Color.Transparent;
            this.urlField.BorderColor = System.Drawing.Color.Silver;
            this.urlField.BorderRadius = 12;
            this.urlField.BorderThickness = 2;
            this.urlField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.urlField.DefaultText = "";
            this.urlField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.urlField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.urlField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.urlField.DisabledState.Parent = this.urlField;
            this.urlField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.urlField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.urlField.FocusedState.Parent = this.urlField;
            this.urlField.ForeColor = System.Drawing.Color.Black;
            this.urlField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.urlField.HoverState.Parent = this.urlField;
            this.urlField.Location = new System.Drawing.Point(250, 3);
            this.urlField.Name = "urlField";
            this.urlField.PasswordChar = '\0';
            this.urlField.PlaceholderText = "blank: about";
            this.urlField.SelectedText = "";
            this.urlField.ShadowDecoration.Parent = this.urlField;
            this.urlField.Size = new System.Drawing.Size(576, 27);
            this.urlField.TabIndex = 1;
            this.urlField.TextChanged += new System.EventHandler(this.urlField_TextChanged);
            this.urlField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.urlField_KeyDown);
            this.urlField.MouseClick += new System.Windows.Forms.MouseEventHandler(this.urlField_MouseClick);
            // 
            // pictureIcon
            // 
            this.pictureIcon.Image = global::Meelo_Browser.Properties.Resources.globe_96px;
            this.pictureIcon.InitialImage = null;
            this.pictureIcon.Location = new System.Drawing.Point(219, 3);
            this.pictureIcon.Name = "pictureIcon";
            this.pictureIcon.Size = new System.Drawing.Size(25, 25);
            this.pictureIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureIcon.TabIndex = 1;
            this.pictureIcon.TabStop = false;
            this.pictureIcon.MouseHover += new System.EventHandler(this.pictureIcon_MouseHover);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.BackgroundImage = global::Meelo_Browser.Properties.Resources.grid_2_48px;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSettings.ContextMenuStrip = this.optionMenu;
            this.btnSettings.Location = new System.Drawing.Point(916, 3);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(25, 25);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.UseSelectable = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            this.btnSettings.MouseLeave += new System.EventHandler(this.btnSettings_MouseLeave);
            this.btnSettings.MouseHover += new System.EventHandler(this.btnSettings_MouseHover);
            // 
            // btnReload
            // 
            this.btnReload.BackgroundImage = global::Meelo_Browser.Properties.Resources.recurring_appointment_52px;
            this.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReload.Location = new System.Drawing.Point(95, 3);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(25, 25);
            this.btnReload.TabIndex = 1;
            this.btnReload.UseSelectable = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            this.btnReload.MouseLeave += new System.EventHandler(this.btnReload_MouseLeave);
            this.btnReload.MouseHover += new System.EventHandler(this.btnReload_MouseHover);
            // 
            // btnForward
            // 
            this.btnForward.BackgroundImage = global::Meelo_Browser.Properties.Resources.forward_52px;
            this.btnForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnForward.Location = new System.Drawing.Point(34, 3);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(25, 25);
            this.btnForward.TabIndex = 1;
            this.btnForward.UseSelectable = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            this.btnForward.MouseLeave += new System.EventHandler(this.btnForward_MouseLeave);
            this.btnForward.MouseHover += new System.EventHandler(this.btnForward_MouseHover);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::Meelo_Browser.Properties.Resources.back_52px;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(25, 25);
            this.btnBack.TabIndex = 0;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            this.btnBack.MouseHover += new System.EventHandler(this.btnBack_MouseHover);
            // 
            // historyBindingSource
            // 
            this.historyBindingSource.DataMember = "history";
            this.historyBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // browserPanel
            // 
            this.browserPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browserPanel.BackColor = System.Drawing.Color.White;
            this.browserPanel.Controls.Add(this.visitPanel);
            this.browserPanel.Location = new System.Drawing.Point(0, 34);
            this.browserPanel.Name = "browserPanel";
            this.browserPanel.Size = new System.Drawing.Size(944, 491);
            this.browserPanel.TabIndex = 1;
            // 
            // visitPanel
            // 
            this.visitPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.visitPanel.BackColor = System.Drawing.Color.Transparent;
            this.visitPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.visitPanel.Controls.Add(this.guna2HtmlLabel1);
            this.visitPanel.Controls.Add(this.btnMeelo);
            this.visitPanel.Controls.Add(this.htmlTwitter);
            this.visitPanel.Controls.Add(this.htmlYoutube);
            this.visitPanel.Controls.Add(this.htmlFacebook);
            this.visitPanel.Controls.Add(this.htmlGoogle);
            this.visitPanel.Controls.Add(this.btnTwitter);
            this.visitPanel.Controls.Add(this.btnYoutube);
            this.visitPanel.Controls.Add(this.btnFacebook);
            this.visitPanel.Controls.Add(this.btnGoogle);
            this.visitPanel.Location = new System.Drawing.Point(113, 53);
            this.visitPanel.Name = "visitPanel";
            this.visitPanel.Size = new System.Drawing.Size(725, 317);
            this.visitPanel.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(143, 269);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(51, 22);
            this.guna2HtmlLabel1.TabIndex = 3;
            this.guna2HtmlLabel1.Text = "Meelo";
            // 
            // btnMeelo
            // 
            this.btnMeelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnMeelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMeelo.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnMeelo.BorderThickness = 2;
            this.btnMeelo.CheckedState.Parent = this.btnMeelo;
            this.btnMeelo.CustomImages.Parent = this.btnMeelo;
            this.btnMeelo.FillColor = System.Drawing.Color.Empty;
            this.btnMeelo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMeelo.ForeColor = System.Drawing.Color.DarkRed;
            this.btnMeelo.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnMeelo.HoverState.Parent = this.btnMeelo;
            this.btnMeelo.Image = global::Meelo_Browser.Properties.Resources.meeloIcon;
            this.btnMeelo.Location = new System.Drawing.Point(135, 172);
            this.btnMeelo.Name = "btnMeelo";
            this.btnMeelo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMeelo.ShadowDecoration.Parent = this.btnMeelo;
            this.btnMeelo.Size = new System.Drawing.Size(80, 80);
            this.btnMeelo.TabIndex = 2;
            this.btnMeelo.Click += new System.EventHandler(this.btnMeelo_Click);
            // 
            // htmlTwitter
            // 
            this.htmlTwitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.htmlTwitter.BackColor = System.Drawing.Color.Transparent;
            this.htmlTwitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlTwitter.Location = new System.Drawing.Point(525, 144);
            this.htmlTwitter.Name = "htmlTwitter";
            this.htmlTwitter.Size = new System.Drawing.Size(57, 22);
            this.htmlTwitter.TabIndex = 1;
            this.htmlTwitter.Text = "Twitter";
            // 
            // htmlYoutube
            // 
            this.htmlYoutube.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.htmlYoutube.BackColor = System.Drawing.Color.Transparent;
            this.htmlYoutube.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlYoutube.Location = new System.Drawing.Point(395, 144);
            this.htmlYoutube.Name = "htmlYoutube";
            this.htmlYoutube.Size = new System.Drawing.Size(71, 22);
            this.htmlYoutube.TabIndex = 1;
            this.htmlYoutube.Text = "Youtube";
            // 
            // htmlFacebook
            // 
            this.htmlFacebook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.htmlFacebook.BackColor = System.Drawing.Color.Transparent;
            this.htmlFacebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlFacebook.Location = new System.Drawing.Point(268, 144);
            this.htmlFacebook.Name = "htmlFacebook";
            this.htmlFacebook.Size = new System.Drawing.Size(82, 22);
            this.htmlFacebook.TabIndex = 1;
            this.htmlFacebook.Text = "Facebook";
            // 
            // htmlGoogle
            // 
            this.htmlGoogle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.htmlGoogle.BackColor = System.Drawing.Color.Transparent;
            this.htmlGoogle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlGoogle.Location = new System.Drawing.Point(143, 144);
            this.htmlGoogle.Name = "htmlGoogle";
            this.htmlGoogle.Size = new System.Drawing.Size(61, 22);
            this.htmlGoogle.TabIndex = 1;
            this.htmlGoogle.Text = "Google";
            // 
            // btnTwitter
            // 
            this.btnTwitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnTwitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTwitter.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnTwitter.BorderThickness = 2;
            this.btnTwitter.CheckedState.Parent = this.btnTwitter;
            this.btnTwitter.CustomImages.Parent = this.btnTwitter;
            this.btnTwitter.FillColor = System.Drawing.Color.Empty;
            this.btnTwitter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTwitter.ForeColor = System.Drawing.Color.DarkRed;
            this.btnTwitter.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnTwitter.HoverState.Parent = this.btnTwitter;
            this.btnTwitter.Location = new System.Drawing.Point(515, 47);
            this.btnTwitter.Name = "btnTwitter";
            this.btnTwitter.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnTwitter.ShadowDecoration.Parent = this.btnTwitter;
            this.btnTwitter.Size = new System.Drawing.Size(80, 80);
            this.btnTwitter.TabIndex = 0;
            this.btnTwitter.Click += new System.EventHandler(this.btnTwitter_Click);
            // 
            // btnYoutube
            // 
            this.btnYoutube.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnYoutube.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnYoutube.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnYoutube.BorderThickness = 2;
            this.btnYoutube.CheckedState.Parent = this.btnYoutube;
            this.btnYoutube.CustomImages.Parent = this.btnYoutube;
            this.btnYoutube.FillColor = System.Drawing.Color.Empty;
            this.btnYoutube.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnYoutube.ForeColor = System.Drawing.Color.DarkRed;
            this.btnYoutube.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnYoutube.HoverState.Parent = this.btnYoutube;
            this.btnYoutube.Location = new System.Drawing.Point(386, 47);
            this.btnYoutube.Name = "btnYoutube";
            this.btnYoutube.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnYoutube.ShadowDecoration.Parent = this.btnYoutube;
            this.btnYoutube.Size = new System.Drawing.Size(80, 80);
            this.btnYoutube.TabIndex = 0;
            this.btnYoutube.Click += new System.EventHandler(this.btnYoutube_Click);
            // 
            // btnFacebook
            // 
            this.btnFacebook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnFacebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFacebook.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnFacebook.BorderThickness = 2;
            this.btnFacebook.CheckedState.Parent = this.btnFacebook;
            this.btnFacebook.CustomImages.Parent = this.btnFacebook;
            this.btnFacebook.FillColor = System.Drawing.Color.Empty;
            this.btnFacebook.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFacebook.ForeColor = System.Drawing.Color.DarkRed;
            this.btnFacebook.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnFacebook.HoverState.Parent = this.btnFacebook;
            this.btnFacebook.Location = new System.Drawing.Point(264, 47);
            this.btnFacebook.Name = "btnFacebook";
            this.btnFacebook.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnFacebook.ShadowDecoration.Parent = this.btnFacebook;
            this.btnFacebook.Size = new System.Drawing.Size(80, 80);
            this.btnFacebook.TabIndex = 0;
            this.btnFacebook.Click += new System.EventHandler(this.btnFacebook_Click);
            // 
            // btnGoogle
            // 
            this.btnGoogle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnGoogle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGoogle.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnGoogle.BorderThickness = 2;
            this.btnGoogle.CheckedState.Parent = this.btnGoogle;
            this.btnGoogle.CustomImages.Parent = this.btnGoogle;
            this.btnGoogle.FillColor = System.Drawing.Color.Empty;
            this.btnGoogle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGoogle.ForeColor = System.Drawing.Color.DarkRed;
            this.btnGoogle.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnGoogle.HoverState.Parent = this.btnGoogle;
            this.btnGoogle.Image = global::Meelo_Browser.Properties.Resources.forward_52px;
            this.btnGoogle.Location = new System.Drawing.Point(135, 47);
            this.btnGoogle.Name = "btnGoogle";
            this.btnGoogle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnGoogle.ShadowDecoration.Parent = this.btnGoogle;
            this.btnGoogle.Size = new System.Drawing.Size(80, 80);
            this.btnGoogle.TabIndex = 0;
            this.btnGoogle.Click += new System.EventHandler(this.btnGoogle_Click);
            // 
            // historyTableAdapter
            // 
            this.historyTableAdapter.ClearBeforeFill = true;
            // 
            // BrowserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.browserPanel);
            this.Controls.Add(this.panel1);
            this.Name = "BrowserControl";
            this.Size = new System.Drawing.Size(944, 525);
            this.panel1.ResumeLayout(false);
            this.optionMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            this.browserPanel.ResumeLayout(false);
            this.visitPanel.ResumeLayout(false);
            this.visitPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureIcon;
        private MetroFramework.Controls.MetroLink btnSettings;
        private MetroFramework.Controls.MetroLink btnReload;
        private MetroFramework.Controls.MetroLink btnForward;
        private MetroFramework.Controls.MetroLink btnBack;
        private System.Windows.Forms.ContextMenuStrip optionMenu;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel browserPanel;
        private MetroFramework.Controls.MetroLink btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox urlField;
        private System.Windows.Forms.ToolStripMenuItem pdfViewerToolStripMenuItem;
        private System.Windows.Forms.Panel visitPanel;
        private Guna.UI2.WinForms.Guna2CircleButton btnGoogle;
        private Guna.UI2.WinForms.Guna2HtmlLabel htmlTwitter;
        private Guna.UI2.WinForms.Guna2HtmlLabel htmlYoutube;
        private Guna.UI2.WinForms.Guna2HtmlLabel htmlFacebook;
        private Guna.UI2.WinForms.Guna2HtmlLabel htmlGoogle;
        private Guna.UI2.WinForms.Guna2CircleButton btnTwitter;
        private Guna.UI2.WinForms.Guna2CircleButton btnYoutube;
        private Guna.UI2.WinForms.Guna2CircleButton btnFacebook;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2CircleButton btnMeelo;
        private MetroFramework.Controls.MetroLink btnHome;
        private System.Windows.Forms.BindingSource historyBindingSource;
        private AppData appData;
        private AppDataTableAdapters.historyTableAdapter historyTableAdapter;
    }
}
