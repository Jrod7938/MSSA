namespace W4D2Assignment4._2 {
    partial class AdminForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            dgStudents = new DataGridView();
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            nudGPA = new NumericUpDown();
            btnDelete = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dgStudents).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudGPA).BeginInit();
            SuspendLayout();
            // 
            // dgStudents
            // 
            dgStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgStudents.Location = new Point(12, 12);
            dgStudents.Name = "dgStudents";
            dgStudents.Size = new Size(560, 426);
            dgStudents.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(73, 22);
            txtName.Name = "txtName";
            txtName.Size = new Size(131, 23);
            txtName.TabIndex = 1;
            txtName.Validating += txtName_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 66);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 3;
            label2.Text = "GPA";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(nudGPA);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(578, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(210, 147);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "New Student";
            // 
            // button1
            // 
            button1.Location = new Point(73, 108);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // nudGPA
            // 
            nudGPA.DecimalPlaces = 2;
            nudGPA.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudGPA.Location = new Point(73, 58);
            nudGPA.Maximum = new decimal(new int[] { 40, 0, 0, 65536 });
            nudGPA.Name = "nudGPA";
            nudGPA.Size = new Size(131, 23);
            nudGPA.TabIndex = 4;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(603, 233);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(707, 233);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(groupBox1);
            Controls.Add(dgStudents);
            Name = "AdminForm";
            Text = "Admin Form";
            ((System.ComponentModel.ISupportInitialize)dgStudents).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudGPA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgStudents;
        private TextBox txtName;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private NumericUpDown nudGPA;
        private Button button1;
        private Button btnDelete;
        private Button btnSave;
    }
}