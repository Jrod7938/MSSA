namespace W4D1Assignment4._1 {
    partial class AddForm {
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
            btnAdd = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtMobilePhone = new TextBox();
            txtWorkPhone = new TextBox();
            txtAddress = new TextBox();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(50, 225);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(189, 225);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(24, 20);
            label1.Name = "label1";
            label1.Size = new Size(75, 17);
            label1.TabIndex = 2;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(24, 59);
            label2.Name = "label2";
            label2.Size = new Size(73, 17);
            label2.TabIndex = 3;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(24, 100);
            label3.Name = "label3";
            label3.Size = new Size(94, 17);
            label3.TabIndex = 4;
            label3.Text = "Mobile Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(24, 141);
            label4.Name = "label4";
            label4.Size = new Size(84, 17);
            label4.TabIndex = 5;
            label4.Text = "Work Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.Location = new Point(24, 185);
            label5.Name = "label5";
            label5.Size = new Size(57, 17);
            label5.TabIndex = 6;
            label5.Text = "Address";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(176, 14);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 7;
            txtFirstName.Validating += txtFirstName_Validating;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(176, 53);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 8;
            txtLastName.Validating += txtLastName_Validating;
            // 
            // txtMobilePhone
            // 
            txtMobilePhone.Location = new Point(176, 94);
            txtMobilePhone.Name = "txtMobilePhone";
            txtMobilePhone.Size = new Size(100, 23);
            txtMobilePhone.TabIndex = 9;
            txtMobilePhone.Validating += txtMobilePhone_Validating;
            // 
            // txtWorkPhone
            // 
            txtWorkPhone.Location = new Point(176, 135);
            txtWorkPhone.Name = "txtWorkPhone";
            txtWorkPhone.Size = new Size(100, 23);
            txtWorkPhone.TabIndex = 10;
            txtWorkPhone.Validating += txtWorkPhone_Validating;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(176, 179);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 11;
            txtAddress.Validating += txtAddress_Validating;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(288, 267);
            Controls.Add(txtAddress);
            Controls.Add(txtWorkPhone);
            Controls.Add(txtMobilePhone);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Name = "AddForm";
            Text = "Add Person";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnCancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtMobilePhone;
        private TextBox txtWorkPhone;
        private TextBox txtAddress;
    }
}