


namespace W3D3Assignment3._3
{
    partial class StudentRecords
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
            dgStudentRecords = new DataGridView();
            btnAddStudent = new Button();
            btnDeleteStudent = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgStudentRecords).BeginInit();
            SuspendLayout();
            // 
            // dgStudentRecords
            // 
            dgStudentRecords.BackgroundColor = Color.Azure;
            dgStudentRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgStudentRecords.Location = new Point(12, 12);
            dgStudentRecords.Name = "dgStudentRecords";
            dgStudentRecords.Size = new Size(644, 426);
            dgStudentRecords.TabIndex = 0;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(676, 95);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(103, 46);
            btnAddStudent.TabIndex = 1;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnDeleteStudent
            // 
            btnDeleteStudent.Location = new Point(676, 173);
            btnDeleteStudent.Name = "btnDeleteStudent";
            btnDeleteStudent.Size = new Size(103, 43);
            btnDeleteStudent.TabIndex = 2;
            btnDeleteStudent.Text = "Delete Student";
            btnDeleteStudent.UseVisualStyleBackColor = true;
            btnDeleteStudent.Click += btnDeleteStudent_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(676, 252);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(103, 43);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // StudentRecords
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRefresh);
            Controls.Add(btnDeleteStudent);
            Controls.Add(btnAddStudent);
            Controls.Add(dgStudentRecords);
            Name = "StudentRecords";
            Text = "Student Records";
            Load += StudentRecords_Load;
            ((System.ComponentModel.ISupportInitialize)dgStudentRecords).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgStudentRecords;
        private Button btnAddStudent;
        private Button btnDeleteStudent;
        private Button btnRefresh;
    }
}
