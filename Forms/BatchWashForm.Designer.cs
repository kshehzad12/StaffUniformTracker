namespace StaffUniformTracker.Forms
{
    partial class BatchWashForm
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
            _info = new Label();
            _success = new RadioButton();
            _failure = new RadioButton();
            _runBtn = new Button();
            _items = new CheckedListBox();
            SuspendLayout();
            // 
            // _info
            // 
            _info.AutoSize = true;
            _info.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _info.Location = new Point(21, 9);
            _info.Name = "_info";
            _info.Size = new Size(325, 21);
            _info.TabIndex = 0;
            _info.Text = "Select uniforms to add to the wash batch.";
            // 
            // _success
            // 
            _success.AutoSize = true;
            _success.Location = new Point(21, 67);
            _success.Name = "_success";
            _success.Size = new Size(166, 19);
            _success.TabIndex = 1;
            _success.TabStop = true;
            _success.Text = "Wash Successful (Cleaned)";
            _success.UseVisualStyleBackColor = true;
            // 
            // _failure
            // 
            _failure.AutoSize = true;
            _failure.Location = new Point(196, 67);
            _failure.Name = "_failure";
            _failure.Size = new Size(150, 19);
            _failure.TabIndex = 2;
            _failure.TabStop = true;
            _failure.Text = "Wash Failed (Re-queue)";
            _failure.UseVisualStyleBackColor = true;
            // 
            // _runBtn
            // 
            _runBtn.Location = new Point(22, 98);
            _runBtn.Name = "_runBtn";
            _runBtn.Size = new Size(324, 23);
            _runBtn.TabIndex = 3;
            _runBtn.Text = "Run wash batch";
            _runBtn.UseVisualStyleBackColor = true;
            // 
            // _items
            // 
            _items.Dock = DockStyle.Bottom;
            _items.FormattingEnabled = true;
            _items.IntegralHeight = false;
            _items.Location = new Point(0, 158);
            _items.Name = "_items";
            _items.Size = new Size(397, 292);
            _items.TabIndex = 4;
            // 
            // BatchWashForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 450);
            Controls.Add(_items);
            Controls.Add(_runBtn);
            Controls.Add(_failure);
            Controls.Add(_success);
            Controls.Add(_info);
            Name = "BatchWashForm";
            Text = "Batch Wash";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label _info;
        private RadioButton _success;
        private RadioButton _failure;
        private Button _runBtn;
        private CheckedListBox _items;
    }
}