namespace W4D1Assignment4._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            dgPhoneBook = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgPhoneBook).BeginInit();
            SuspendLayout();
            // 
            // dgPhoneBook
            // 
            dgPhoneBook.BackgroundColor = Color.NavajoWhite;
            dgPhoneBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPhoneBook.Location = new Point(267, 12);
            dgPhoneBook.Name = "dgPhoneBook";
            dgPhoneBook.Size = new Size(563, 426);
            dgPhoneBook.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(27, 147);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(97, 43);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(130, 147);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(97, 43);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(53, 212);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(132, 43);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search Full Name";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(53, 261);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(132, 23);
            txtSearch.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(842, 450);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgPhoneBook);
            Name = "Form1";
            Text = "Phone Book";
            ((System.ComponentModel.ISupportInitialize)dgPhoneBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgPhoneBook;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnSearch;
        private TextBox txtSearch;
    }
}
