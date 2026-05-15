namespace StaffUniformTracker.Forms
{
    partial class ClientsForm
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
            _list = new ListBox();
            _id = new TextBox();
            _name = new TextBox();
            _email = new TextBox();
            _addBtn = new Button();
            _delBtn = new Button();
            SuspendLayout();
            // 
            // _list
            // 
            _list.Dock = DockStyle.Left;
            _list.FormattingEnabled = true;
            _list.IntegralHeight = false;
            _list.ItemHeight = 15;
            _list.Location = new Point(0, 0);
            _list.Name = "_list";
            _list.Size = new Size(320, 421);
            _list.TabIndex = 0;
            // 
            // _id
            // 
            _id.Location = new Point(326, 12);
            _id.Name = "_id";
            _id.PlaceholderText = "Client ID (e,g C-003)";
            _id.Size = new Size(320, 23);
            _id.TabIndex = 1;
            // 
            // _name
            // 
            _name.Location = new Point(326, 50);
            _name.Name = "_name";
            _name.PlaceholderText = "Client Name";
            _name.Size = new Size(320, 23);
            _name.TabIndex = 2;
            // 
            // _email
            // 
            _email.Location = new Point(326, 93);
            _email.Name = "_email";
            _email.PlaceholderText = "Contact email";
            _email.Size = new Size(320, 23);
            _email.TabIndex = 3;
            // 
            // _addBtn
            // 
            _addBtn.Location = new Point(326, 169);
            _addBtn.Name = "_addBtn";
            _addBtn.Size = new Size(150, 23);
            _addBtn.TabIndex = 4;
            _addBtn.Text = "Add / Update";
            _addBtn.UseVisualStyleBackColor = true;
            // 
            // _delBtn
            // 
            _delBtn.Location = new Point(496, 169);
            _delBtn.Name = "_delBtn";
            _delBtn.Size = new Size(150, 23);
            _delBtn.TabIndex = 5;
            _delBtn.Text = "Remove";
            _delBtn.UseVisualStyleBackColor = true;
            // 
            // ClientsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 421);
            Controls.Add(_delBtn);
            Controls.Add(_addBtn);
            Controls.Add(_email);
            Controls.Add(_name);
            Controls.Add(_id);
            Controls.Add(_list);
            Name = "ClientsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Manage Clients";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox _list;
        private TextBox _id;
        private TextBox _name;
        private TextBox _email;
        private Button _addBtn;
        private Button _delBtn;
    }
}