namespace StaffUniformTracker.Forms
{
    partial class StaffForm
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
            _lblClient = new Label();
            _client = new ComboBox();
            _importBtn = new Button();
            _list = new ListBox();
            SuspendLayout();
            // 
            // _lblClient
            // 
            _lblClient.AutoSize = true;
            _lblClient.Location = new Point(12, 9);
            _lblClient.Name = "_lblClient";
            _lblClient.Size = new Size(38, 15);
            _lblClient.TabIndex = 0;
            _lblClient.Text = "Client";
            // 
            // _client
            // 
            _client.DropDownStyle = ComboBoxStyle.DropDownList;
            _client.FormattingEnabled = true;
            _client.Location = new Point(76, 5);
            _client.Name = "_client";
            _client.Size = new Size(305, 23);
            _client.TabIndex = 1;
            // 
            // _importBtn
            // 
            _importBtn.Location = new Point(12, 45);
            _importBtn.Name = "_importBtn";
            _importBtn.Size = new Size(369, 23);
            _importBtn.TabIndex = 2;
            _importBtn.Text = "Import From HR System (Adapter)";
            _importBtn.UseVisualStyleBackColor = true;
            // 
            // _list
            // 
            _list.Dock = DockStyle.Bottom;
            _list.FormattingEnabled = true;
            _list.ItemHeight = 15;
            _list.Location = new Point(0, 101);
            _list.Name = "_list";
            _list.Size = new Size(484, 349);
            _list.TabIndex = 3;
            // 
            // StaffForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 450);
            Controls.Add(_list);
            Controls.Add(_importBtn);
            Controls.Add(_client);
            Controls.Add(_lblClient);
            Name = "StaffForm";
            Text = "Manage Staff";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label _lblClient;
        private ComboBox _client;
        private Button _importBtn;
        private ListBox _list;
    }
}