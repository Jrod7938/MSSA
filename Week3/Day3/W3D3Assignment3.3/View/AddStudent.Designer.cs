namespace W3D3Assignment3._3.View {
    partial class AddStudent {
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
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtAddress = new TextBox();
            cbMonthofAdmission = new ComboBox();
            cbGrade = new ComboBox();
            txtb = new Label();
            txtb1 = new Label();
            txtb2 = new Label();
            txtb3 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            btnSubmit = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(266, 32);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(121, 25);
            txtFirstName.TabIndex = 0;
            txtFirstName.Validating += txtFirstName_Validating;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(266, 77);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(121, 25);
            txtLastName.TabIndex = 1;
            txtLastName.Validating += txtLastName_Validating;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(266, 124);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(121, 25);
            txtAddress.TabIndex = 2;
            txtAddress.Validating += txtAddress_Validating;
            // 
            // cbMonthofAdmission
            // 
            cbMonthofAdmission.FormattingEnabled = true;
            cbMonthofAdmission.Location = new Point(266, 169);
            cbMonthofAdmission.Name = "cbMonthofAdmission";
            cbMonthofAdmission.Size = new Size(121, 25);
            cbMonthofAdmission.TabIndex = 3;
            // 
            // cbGrade
            // 
            cbGrade.FormattingEnabled = true;
            cbGrade.Location = new Point(266, 213);
            cbGrade.Name = "cbGrade";
            cbGrade.Size = new Size(121, 25);
            cbGrade.TabIndex = 4;
            // 
            // txtb
            // 
            txtb.AutoSize = true;
            txtb.Location = new Point(53, 40);
            txtb.Name = "txtb";
            txtb.Size = new Size(75, 17);
            txtb.TabIndex = 5;
            txtb.Text = "First Name";
            // 
            // txtb1
            // 
            txtb1.AutoSize = true;
            txtb1.Location = new Point(53, 85);
            txtb1.Name = "txtb1";
            txtb1.Size = new Size(73, 17);
            txtb1.TabIndex = 6;
            txtb1.Text = "Last Name";
            // 
            // txtb2
            // 
            txtb2.AutoSize = true;
            txtb2.Location = new Point(53, 132);
            txtb2.Name = "txtb2";
            txtb2.Size = new Size(57, 17);
            txtb2.TabIndex = 7;
            txtb2.Text = "Address";
            // 
            // txtb3
            // 
            txtb3.AutoSize = true;
            txtb3.Location = new Point(53, 177);
            txtb3.Name = "txtb3";
            txtb3.Size = new Size(135, 17);
            txtb3.TabIndex = 8;
            txtb3.Text = "Month of Admission";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 221);
            label5.Name = "label5";
            label5.Size = new Size(44, 17);
            label5.TabIndex = 9;
            label5.Text = "Grade";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSubmit);
            groupBox1.Controls.Add(txtb);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtb3);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(txtb2);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(txtb1);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(cbMonthofAdmission);
            groupBox1.Controls.Add(cbGrade);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(440, 312);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "New Student";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(174, 270);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(93, 26);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(468, 342);
            Controls.Add(groupBox1);
            Name = "AddStudent";
            Text = "Add Student Form";
            Load += AddStudent_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtAddress;
        private ComboBox cbMonthofAdmission;
        private ComboBox cbGrade;
        private Label txtb;
        private Label txtb1;
        private Label txtb2;
        private Label txtb3;
        private Label label5;
        private GroupBox groupBox1;
        private Button btnSubmit;
    }
}