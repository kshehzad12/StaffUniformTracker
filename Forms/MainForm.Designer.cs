namespace StaffUniformTracker.Forms
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            _menu = new MenuStrip();
            manageToolStripMenuItem = new ToolStripMenuItem();
            operationsToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            _menuClients = new ToolStripMenuItem();
            _menuStaff = new ToolStripMenuItem();
            _menuUniforms = new ToolStripMenuItem();
            _menuBatch = new ToolStripMenuItem();
            _menuSearch = new ToolStripMenuItem();
            _menuReport = new ToolStripMenuItem();
            _menuAudit = new ToolStripMenuItem();
            _menuAbout = new ToolStripMenuItem();
            _layout = new TableLayoutPanel();
            _topPanel = new Panel();
            _welcome = new Label();
            _counts = new Label();
            _feedHeading = new Label();
            _activity = new ListBox();
            _menu.SuspendLayout();
            _layout.SuspendLayout();
            _topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // _menu
            // 
            _menu.Items.AddRange(new ToolStripItem[] { manageToolStripMenuItem, operationsToolStripMenuItem, reportsToolStripMenuItem, helpToolStripMenuItem });
            _menu.Location = new Point(0, 0);
            _menu.Name = "_menu";
            _menu.Size = new Size(800, 24);
            _menu.TabIndex = 0;
            _menu.Text = "menuStrip1";
            // 
            // manageToolStripMenuItem
            // 
            manageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { _menuClients, _menuStaff, _menuUniforms });
            manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            manageToolStripMenuItem.Size = new Size(62, 20);
            manageToolStripMenuItem.Text = "Manage";
            // 
            // operationsToolStripMenuItem
            // 
            operationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { _menuBatch, _menuSearch });
            operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            operationsToolStripMenuItem.Size = new Size(77, 20);
            operationsToolStripMenuItem.Text = "Operations";
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { _menuReport, _menuAudit });
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(59, 20);
            reportsToolStripMenuItem.Text = "Reports";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { _menuAbout });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // _menuClients
            // 
            _menuClients.Name = "_menuClients";
            _menuClients.Size = new Size(118, 22);
            _menuClients.Text = "Clients";
            // 
            // _menuStaff
            // 
            _menuStaff.Name = "_menuStaff";
            _menuStaff.Size = new Size(118, 22);
            _menuStaff.Text = "Staff";
            // 
            // _menuUniforms
            // 
            _menuUniforms.Name = "_menuUniforms";
            _menuUniforms.Size = new Size(118, 22);
            _menuUniforms.Text = "Uniform";
            // 
            // _menuBatch
            // 
            _menuBatch.Name = "_menuBatch";
            _menuBatch.Size = new Size(180, 22);
            _menuBatch.Text = "Batch Wash";
            // 
            // _menuSearch
            // 
            _menuSearch.Name = "_menuSearch";
            _menuSearch.Size = new Size(180, 22);
            _menuSearch.Text = "Search";
            // 
            // _menuReport
            // 
            _menuReport.Name = "_menuReport";
            _menuReport.Size = new Size(180, 22);
            _menuReport.Text = "Generate Reports";
            // 
            // _menuAudit
            // 
            _menuAudit.Name = "_menuAudit";
            _menuAudit.Size = new Size(180, 22);
            _menuAudit.Text = "Audit Logs";
            // 
            // _menuAbout
            // 
            _menuAbout.Name = "_menuAbout";
            _menuAbout.Size = new Size(180, 22);
            _menuAbout.Text = "About";
            // 
            // _layout
            // 
            _layout.ColumnCount = 1;
            _layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            _layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            _layout.Controls.Add(_topPanel, 0, 0);
            _layout.Controls.Add(_feedHeading, 0, 1);
            _layout.Dock = DockStyle.Fill;
            _layout.Location = new Point(0, 24);
            _layout.Name = "_layout";
            _layout.RowCount = 2;
            _layout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            _layout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            _layout.Size = new Size(800, 426);
            _layout.TabIndex = 1;
            // 
            // _topPanel
            // 
            _topPanel.BackColor = SystemColors.Control;
            _topPanel.Controls.Add(_activity);
            _topPanel.Controls.Add(_counts);
            _topPanel.Controls.Add(_welcome);
            _topPanel.Dock = DockStyle.Fill;
            _topPanel.Location = new Point(3, 3);
            _topPanel.Name = "_topPanel";
            _topPanel.Size = new Size(794, 207);
            _topPanel.TabIndex = 0;
            // 
            // _welcome
            // 
            _welcome.AutoSize = true;
            _welcome.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _welcome.Location = new Point(3, 0);
            _welcome.Name = "_welcome";
            _welcome.Size = new Size(150, 23);
            _welcome.TabIndex = 0;
            _welcome.Text = "Welcome, admin.";
            // 
            // _counts
            // 
            _counts.AutoSize = true;
            _counts.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _counts.Location = new Point(9, 23);
            _counts.Name = "_counts";
            _counts.Size = new Size(181, 17);
            _counts.TabIndex = 1;
            _counts.Text = "Clients: ... Staff: ... Uniforms: ...";
            // 
            // _feedHeading
            // 
            _feedHeading.AutoSize = true;
            _feedHeading.Dock = DockStyle.Top;
            _feedHeading.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            _feedHeading.Location = new Point(3, 213);
            _feedHeading.Name = "_feedHeading";
            _feedHeading.Size = new Size(794, 15);
            _feedHeading.TabIndex = 1;
            _feedHeading.Text = "Live audit feed (Observer pattern)";
            // 
            // _activity
            // 
            _activity.Dock = DockStyle.Fill;
            _activity.FormattingEnabled = true;
            _activity.ItemHeight = 15;
            _activity.Location = new Point(0, 0);
            _activity.Name = "_activity";
            _activity.Size = new Size(794, 207);
            _activity.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(_layout);
            Controls.Add(_menu);
            MainMenuStrip = _menu;
            MinimumSize = new Size(720, 480);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            _menu.ResumeLayout(false);
            _menu.PerformLayout();
            _layout.ResumeLayout(false);
            _layout.PerformLayout();
            _topPanel.ResumeLayout(false);
            _topPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip _menu;
        private ToolStripMenuItem manageToolStripMenuItem;
        private ToolStripMenuItem _menuClients;
        private ToolStripMenuItem _menuStaff;
        private ToolStripMenuItem _menuUniforms;
        private ToolStripMenuItem operationsToolStripMenuItem;
        private ToolStripMenuItem _menuBatch;
        private ToolStripMenuItem _menuSearch;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem _menuReport;
        private ToolStripMenuItem _menuAudit;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem _menuAbout;
        private TableLayoutPanel _layout;
        private Panel _topPanel;
        private Label _welcome;
        private Label _counts;
        private Label _feedHeading;
        private ListBox _activity;
    }
}