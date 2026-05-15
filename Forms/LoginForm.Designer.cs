namespace StaffUniformTracker.Forms
{
    partial class LoginForm
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
            _title = new Label();
            _hint = new Label();
            _user = new TextBox();
            _pass = new TextBox();
            _ok = new Button();
            _err = new Label();
            SuspendLayout();
            // 
            // _title
            // 
            _title.AutoSize = true;
            _title.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _title.Location = new Point(12, 9);
            _title.Name = "_title";
            _title.Size = new Size(188, 25);
            _title.TabIndex = 0;
            _title.Text = "Staff Uniform Tracker";
            _title.Click += label1_Click;
            // 
            // _hint
            // 
            _hint.AutoSize = true;
            _hint.Location = new Point(12, 43);
            _hint.Name = "_hint";
            _hint.Size = new Size(220, 15);
            _hint.TabIndex = 1;
            _hint.Text = "Use your Unername & Password to Sign in";
            _hint.Click += label2_Click;
            // 
            // _user
            // 
            _user.Location = new Point(12, 74);
            _user.Name = "_user";
            _user.Size = new Size(220, 23);
            _user.TabIndex = 2;
            _user.Text = "Username (admin)";
            _user.TextChanged += textBox1_TextChanged;
            // 
            // _pass
            // 
            _pass.Location = new Point(12, 103);
            _pass.Name = "_pass";
            _pass.Size = new Size(220, 23);
            _pass.TabIndex = 3;
            _pass.Text = "Password (admin)";
            _pass.UseSystemPasswordChar = true;
            // 
            // _ok
            // 
            _ok.Location = new Point(12, 144);
            _ok.Name = "_ok";
            _ok.Size = new Size(220, 32);
            _ok.TabIndex = 4;
            _ok.Text = "Sign In";
            _ok.UseVisualStyleBackColor = true;
            // 
            // _err
            // 
            _err.AutoSize = true;
            _err.ForeColor = Color.IndianRed;
            _err.Location = new Point(12, 187);
            _err.Name = "_err";
            _err.Size = new Size(0, 15);
            _err.TabIndex = 5;
            // 
            // LoginForm
            // 
            AcceptButton = _ok;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 211);
            Controls.Add(_err);
            Controls.Add(_ok);
            Controls.Add(_pass);
            Controls.Add(_user);
            Controls.Add(_hint);
            Controls.Add(_title);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Staff Uniform Tracker - Sign in";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label _title;
        private Label _hint;
        private TextBox _user;
        private TextBox _pass;
        private Button _ok;
        private Label _err;
    }
}