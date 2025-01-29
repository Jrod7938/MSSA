namespace W3D3C3 {
    partial class AddEmployeeForm {
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
            grpEmployee = new GroupBox();
            btSubmit = new Button();
            cbEmployeeDepartment = new ComboBox();
            txtEmployeeeSalary = new TextBox();
            txtEmployeeAddress = new TextBox();
            txtEmployeeName = new TextBox();
            txtEmployeeId = new TextBox();
            lblEmployeeDepartment = new Label();
            lblEmployeeSalary = new Label();
            lblEmployeeAddress = new Label();
            lblEmployeeName = new Label();
            lblEmployeeId = new Label();
            grpEmployee.SuspendLayout();
            SuspendLayout();
            // 
            // grpEmployee
            // 
            grpEmployee.Controls.Add(btSubmit);
            grpEmployee.Controls.Add(cbEmployeeDepartment);
            grpEmployee.Controls.Add(txtEmployeeeSalary);
            grpEmployee.Controls.Add(txtEmployeeAddress);
            grpEmployee.Controls.Add(txtEmployeeName);
            grpEmployee.Controls.Add(txtEmployeeId);
            grpEmployee.Controls.Add(lblEmployeeDepartment);
            grpEmployee.Controls.Add(lblEmployeeSalary);
            grpEmployee.Controls.Add(lblEmployeeAddress);
            grpEmployee.Controls.Add(lblEmployeeName);
            grpEmployee.Controls.Add(lblEmployeeId);
            grpEmployee.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpEmployee.Location = new Point(205, 110);
            grpEmployee.Name = "grpEmployee";
            grpEmployee.Size = new Size(346, 226);
            grpEmployee.TabIndex = 0;
            grpEmployee.TabStop = false;
            grpEmployee.Text = "Employee Record";
            // 
            // btSubmit
            // 
            btSubmit.Location = new Point(133, 197);
            btSubmit.Name = "btSubmit";
            btSubmit.Size = new Size(75, 23);
            btSubmit.TabIndex = 10;
            btSubmit.Text = "Submit";
            btSubmit.UseVisualStyleBackColor = true;
            btSubmit.Click += btSubmit_Click;
            // 
            // cbEmployeeDepartment
            // 
            cbEmployeeDepartment.FormattingEnabled = true;
            cbEmployeeDepartment.Location = new Point(203, 162);
            cbEmployeeDepartment.Name = "cbEmployeeDepartment";
            cbEmployeeDepartment.Size = new Size(100, 23);
            cbEmployeeDepartment.TabIndex = 9;
            // 
            // txtEmployeeeSalary
            // 
            txtEmployeeeSalary.Location = new Point(203, 130);
            txtEmployeeeSalary.Name = "txtEmployeeeSalary";
            txtEmployeeeSalary.Size = new Size(100, 23);
            txtEmployeeeSalary.TabIndex = 8;
            txtEmployeeeSalary.Validating += txtEmployeeeSalary_Validating;
            // 
            // txtEmployeeAddress
            // 
            txtEmployeeAddress.Location = new Point(203, 86);
            txtEmployeeAddress.Multiline = true;
            txtEmployeeAddress.Name = "txtEmployeeAddress";
            txtEmployeeAddress.Size = new Size(100, 38);
            txtEmployeeAddress.TabIndex = 7;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(203, 57);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(100, 23);
            txtEmployeeName.TabIndex = 6;
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.Location = new Point(203, 28);
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.Size = new Size(100, 23);
            txtEmployeeId.TabIndex = 5;
            txtEmployeeId.Validating += txtEmployeeId_Validating;
            // 
            // lblEmployeeDepartment
            // 
            lblEmployeeDepartment.AutoSize = true;
            lblEmployeeDepartment.Location = new Point(18, 162);
            lblEmployeeDepartment.Name = "lblEmployeeDepartment";
            lblEmployeeDepartment.Size = new Size(133, 15);
            lblEmployeeDepartment.TabIndex = 4;
            lblEmployeeDepartment.Text = "Employee Department";
            // 
            // lblEmployeeSalary
            // 
            lblEmployeeSalary.AutoSize = true;
            lblEmployeeSalary.Location = new Point(18, 138);
            lblEmployeeSalary.Name = "lblEmployeeSalary";
            lblEmployeeSalary.Size = new Size(97, 15);
            lblEmployeeSalary.TabIndex = 3;
            lblEmployeeSalary.Text = "Employee Salary";
            // 
            // lblEmployeeAddress
            // 
            lblEmployeeAddress.AutoSize = true;
            lblEmployeeAddress.Location = new Point(18, 89);
            lblEmployeeAddress.Name = "lblEmployeeAddress";
            lblEmployeeAddress.Size = new Size(108, 15);
            lblEmployeeAddress.TabIndex = 2;
            lblEmployeeAddress.Text = "Employee Address";
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Location = new Point(18, 65);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(97, 15);
            lblEmployeeName.TabIndex = 1;
            lblEmployeeName.Text = "Employee Name";
            // 
            // lblEmployeeId
            // 
            lblEmployeeId.AutoSize = true;
            lblEmployeeId.Location = new Point(18, 36);
            lblEmployeeId.Name = "lblEmployeeId";
            lblEmployeeId.Size = new Size(75, 15);
            lblEmployeeId.TabIndex = 0;
            lblEmployeeId.Text = "Employee Id";
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpEmployee);
            Name = "AddEmployeeForm";
            Text = "AddEmployeeForm";
            Load += AddEmployeeForm_Load;
            Enter += btSubmit_Click;
            grpEmployee.ResumeLayout(false);
            grpEmployee.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpEmployee;
        private Label lblEmployeeDepartment;
        private Label lblEmployeeSalary;
        private Label lblEmployeeAddress;
        private Label lblEmployeeName;
        private Label lblEmployeeId;
        private TextBox txtEmployeeeSalary;
        private TextBox txtEmployeeAddress;
        private TextBox txtEmployeeName;
        private TextBox txtEmployeeId;
        private Button btSubmit;
        private ComboBox cbEmployeeDepartment;
    }
}