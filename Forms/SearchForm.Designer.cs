namespace StaffUniformTracker.Forms
{
    partial class SearchForm
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
            _lblSearch = new Label();
            _kind = new ComboBox();
            _lblCriterion = new Label();
            _criterion = new TextBox();
            _runBtn = new Button();
            _results = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            SuspendLayout();
            // 
            // _lblSearch
            // 
            _lblSearch.AutoSize = true;
            _lblSearch.Location = new Point(15, 14);
            _lblSearch.Name = "_lblSearch";
            _lblSearch.Size = new Size(61, 15);
            _lblSearch.TabIndex = 0;
            _lblSearch.Text = "Search By:";
            // 
            // _kind
            // 
            _kind.DropDownStyle = ComboBoxStyle.DropDownList;
            _kind.FormattingEnabled = true;
            _kind.Items.AddRange(new object[] { "Client", "Staff", "Status" });
            _kind.Location = new Point(93, 11);
            _kind.Name = "_kind";
            _kind.Size = new Size(121, 23);
            _kind.TabIndex = 1;
            // 
            // _lblCriterion
            // 
            _lblCriterion.AutoSize = true;
            _lblCriterion.Location = new Point(243, 14);
            _lblCriterion.Name = "_lblCriterion";
            _lblCriterion.Size = new Size(53, 15);
            _lblCriterion.TabIndex = 2;
            _lblCriterion.Text = "Criterion";
            // 
            // _criterion
            // 
            _criterion.Location = new Point(326, 11);
            _criterion.Name = "_criterion";
            _criterion.Size = new Size(147, 23);
            _criterion.TabIndex = 3;
            // 
            // _runBtn
            // 
            _runBtn.Location = new Point(493, 11);
            _runBtn.Name = "_runBtn";
            _runBtn.Size = new Size(119, 23);
            _runBtn.TabIndex = 4;
            _runBtn.Text = "Search";
            _runBtn.UseVisualStyleBackColor = true;
            // 
            // _results
            // 
            _results.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            _results.Dock = DockStyle.Bottom;
            _results.GridLines = true;
            _results.Location = new Point(0, 58);
            _results.Name = "_results";
            _results.Size = new Size(635, 392);
            _results.TabIndex = 5;
            _results.UseCompatibleStateImageBehavior = false;
            _results.View = View.Details;
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
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 450);
            Controls.Add(_results);
            Controls.Add(_runBtn);
            Controls.Add(_criterion);
            Controls.Add(_lblCriterion);
            Controls.Add(_kind);
            Controls.Add(_lblSearch);
            Name = "SearchForm";
            Text = "Search Items";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label _lblSearch;
        private ComboBox _kind;
        private Label _lblCriterion;
        private TextBox _criterion;
        private Button _runBtn;
        private ListView _results;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}