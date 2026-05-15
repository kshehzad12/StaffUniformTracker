namespace StaffUniformTracker.Forms
{
    partial class AuditLogForm
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
            _refresh = new Button();
            _subscribe = new Button();
            _list = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            SuspendLayout();
            // 
            // _refresh
            // 
            _refresh.Location = new Point(21, 11);
            _refresh.Name = "_refresh";
            _refresh.Size = new Size(75, 23);
            _refresh.TabIndex = 0;
            _refresh.Text = "Refresh";
            _refresh.UseVisualStyleBackColor = true;
            // 
            // _subscribe
            // 
            _subscribe.Location = new Point(128, 11);
            _subscribe.Name = "_subscribe";
            _subscribe.Size = new Size(188, 23);
            _subscribe.TabIndex = 1;
            _subscribe.Text = "Auto-Refresh on event";
            _subscribe.UseVisualStyleBackColor = true;
            // 
            // _list
            // 
            _list.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            _list.Dock = DockStyle.Bottom;
            _list.Location = new Point(0, 57);
            _list.Name = "_list";
            _list.Size = new Size(690, 183);
            _list.TabIndex = 2;
            _list.UseCompatibleStateImageBehavior = false;
            _list.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Width = 100;
            // 
            // AuditLogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 240);
            Controls.Add(_list);
            Controls.Add(_subscribe);
            Controls.Add(_refresh);
            Name = "AuditLogForm";
            Text = "Audit Log";
            ResumeLayout(false);
        }

        #endregion

        private Button _refresh;
        private Button _subscribe;
        private ListView _list;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}