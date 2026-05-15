namespace StaffUniformTracker.Forms
{
    partial class ReportsForm
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
            _lblFrom = new Label();
            _from = new DateTimePicker();
            _to = new DateTimePicker();
            _lblTo = new Label();
            _genBtn = new Button();
            _output = new TextBox();
            SuspendLayout();
            // 
            // _lblClient
            // 
            _lblClient.AutoSize = true;
            _lblClient.Location = new Point(12, 13);
            _lblClient.Name = "_lblClient";
            _lblClient.Size = new Size(38, 15);
            _lblClient.TabIndex = 0;
            _lblClient.Text = "Client";
            // 
            // _client
            // 
            _client.DropDownStyle = ComboBoxStyle.DropDownList;
            _client.FormattingEnabled = true;
            _client.Location = new Point(67, 10);
            _client.Name = "_client";
            _client.Size = new Size(180, 23);
            _client.TabIndex = 1;
            // 
            // _lblFrom
            // 
            _lblFrom.AutoSize = true;
            _lblFrom.Location = new Point(267, 13);
            _lblFrom.Name = "_lblFrom";
            _lblFrom.Size = new Size(35, 15);
            _lblFrom.TabIndex = 2;
            _lblFrom.Text = "From";
            // 
            // _from
            // 
            _from.Format = DateTimePickerFormat.Short;
            _from.Location = new Point(308, 12);
            _from.Name = "_from";
            _from.Size = new Size(99, 23);
            _from.TabIndex = 3;
            _from.Value = new DateTime(2026, 4, 16, 0, 0, 0, 0);
            // 
            // _to
            // 
            _to.Format = DateTimePickerFormat.Short;
            _to.Location = new Point(477, 13);
            _to.Name = "_to";
            _to.Size = new Size(99, 23);
            _to.TabIndex = 5;
            _to.Value = new DateTime(2026, 5, 16, 0, 0, 0, 0);
            // 
            // _lblTo
            // 
            _lblTo.AutoSize = true;
            _lblTo.Location = new Point(436, 14);
            _lblTo.Name = "_lblTo";
            _lblTo.Size = new Size(20, 15);
            _lblTo.TabIndex = 4;
            _lblTo.Text = "To";
            // 
            // _genBtn
            // 
            _genBtn.Location = new Point(604, 13);
            _genBtn.Name = "_genBtn";
            _genBtn.Size = new Size(75, 23);
            _genBtn.TabIndex = 6;
            _genBtn.Text = "Generate";
            _genBtn.UseVisualStyleBackColor = true;
            // 
            // _output
            // 
            _output.Dock = DockStyle.Bottom;
            _output.Location = new Point(0, 69);
            _output.Multiline = true;
            _output.Name = "_output";
            _output.ReadOnly = true;
            _output.Size = new Size(702, 381);
            _output.TabIndex = 7;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 450);
            Controls.Add(_output);
            Controls.Add(_genBtn);
            Controls.Add(_to);
            Controls.Add(_lblTo);
            Controls.Add(_from);
            Controls.Add(_lblFrom);
            Controls.Add(_client);
            Controls.Add(_lblClient);
            Name = "ReportsForm";
            Text = "Generate Report";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label _lblClient;
        private ComboBox _client;
        private Label _lblFrom;
        private DateTimePicker _from;
        private DateTimePicker _to;
        private Label _lblTo;
        private Button _genBtn;
        private TextBox _output;
    }
}