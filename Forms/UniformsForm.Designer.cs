namespace StaffUniformTracker.Forms
{
    partial class UniformsForm
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
            _typeCombo = new ComboBox();
            _lblType = new Label();
            _lblClient = new Label();
            _clientCombo = new ComboBox();
            _lblStaff = new Label();
            _staffCombo = new ComboBox();
            _addBtn = new Button();
            _soiledBtn = new Button();
            _washBtn = new Button();
            _cleanBtn = new Button();
            _list = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            SuspendLayout();
            // 
            // _typeCombo
            // 
            _typeCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            _typeCombo.FormattingEnabled = true;
            _typeCombo.Location = new Point(85, 27);
            _typeCombo.Name = "_typeCombo";
            _typeCombo.Size = new Size(150, 23);
            _typeCombo.TabIndex = 0;
            // 
            // _lblType
            // 
            _lblType.AutoSize = true;
            _lblType.Location = new Point(26, 30);
            _lblType.Name = "_lblType";
            _lblType.Size = new Size(32, 15);
            _lblType.TabIndex = 1;
            _lblType.Text = "Type";
            // 
            // _lblClient
            // 
            _lblClient.AutoSize = true;
            _lblClient.Location = new Point(274, 33);
            _lblClient.Name = "_lblClient";
            _lblClient.Size = new Size(38, 15);
            _lblClient.TabIndex = 3;
            _lblClient.Text = "Client";
            // 
            // _clientCombo
            // 
            _clientCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            _clientCombo.FormattingEnabled = true;
            _clientCombo.Location = new Point(333, 30);
            _clientCombo.Name = "_clientCombo";
            _clientCombo.Size = new Size(150, 23);
            _clientCombo.TabIndex = 2;
            // 
            // _lblStaff
            // 
            _lblStaff.AutoSize = true;
            _lblStaff.Location = new Point(532, 36);
            _lblStaff.Name = "_lblStaff";
            _lblStaff.Size = new Size(31, 15);
            _lblStaff.TabIndex = 5;
            _lblStaff.Text = "Staff";
            // 
            // _staffCombo
            // 
            _staffCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            _staffCombo.FormattingEnabled = true;
            _staffCombo.Location = new Point(591, 33);
            _staffCombo.Name = "_staffCombo";
            _staffCombo.Size = new Size(204, 23);
            _staffCombo.TabIndex = 4;
            // 
            // _addBtn
            // 
            _addBtn.Location = new Point(85, 68);
            _addBtn.Name = "_addBtn";
            _addBtn.Size = new Size(150, 23);
            _addBtn.TabIndex = 6;
            _addBtn.Text = "Create Uniform";
            _addBtn.UseVisualStyleBackColor = true;
            // 
            // _soiledBtn
            // 
            _soiledBtn.Location = new Point(333, 68);
            _soiledBtn.Name = "_soiledBtn";
            _soiledBtn.Size = new Size(150, 23);
            _soiledBtn.TabIndex = 7;
            _soiledBtn.Text = "Mark Soiled";
            _soiledBtn.UseVisualStyleBackColor = true;
            // 
            // _washBtn
            // 
            _washBtn.Location = new Point(489, 68);
            _washBtn.Name = "_washBtn";
            _washBtn.Size = new Size(150, 23);
            _washBtn.TabIndex = 8;
            _washBtn.Text = "Mark Washing";
            _washBtn.UseVisualStyleBackColor = true;
            // 
            // _cleanBtn
            // 
            _cleanBtn.Location = new Point(645, 68);
            _cleanBtn.Name = "_cleanBtn";
            _cleanBtn.Size = new Size(150, 23);
            _cleanBtn.TabIndex = 9;
            _cleanBtn.Text = "Mark Cleaned";
            _cleanBtn.UseVisualStyleBackColor = true;
            // 
            // _list
            // 
            _list.AllowColumnReorder = true;
            _list.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            _list.Dock = DockStyle.Bottom;
            _list.FullRowSelect = true;
            _list.GridLines = true;
            _list.Location = new Point(0, 123);
            _list.Name = "_list";
            _list.Size = new Size(800, 327);
            _list.TabIndex = 10;
            _list.UseCompatibleStateImageBehavior = false;
            _list.View = View.Details;
            // 
            // UniformsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(_list);
            Controls.Add(_cleanBtn);
            Controls.Add(_washBtn);
            Controls.Add(_soiledBtn);
            Controls.Add(_addBtn);
            Controls.Add(_lblStaff);
            Controls.Add(_staffCombo);
            Controls.Add(_lblClient);
            Controls.Add(_clientCombo);
            Controls.Add(_lblType);
            Controls.Add(_typeCombo);
            Name = "UniformsForm";
            Text = "Manage Uniforms";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox _typeCombo;
        private Label _lblType;
        private Label _lblClient;
        private ComboBox _clientCombo;
        private Label _lblStaff;
        private ComboBox _staffCombo;
        private Button _addBtn;
        private Button _soiledBtn;
        private Button _washBtn;
        private Button _cleanBtn;
        private ListView _list;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}