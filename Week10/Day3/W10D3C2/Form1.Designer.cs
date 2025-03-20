namespace W10D3C2
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
            empGrid = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            employeedDepartmentCb = new ComboBox();
            employeeSalaryTxt = new TextBox();
            employeeNameTxt = new TextBox();
            employeeIdtxt = new TextBox();
            addNewBtn = new Button();
            submitBtn = new Button();
            selectBtn = new Button();
            updateBtn = new Button();
            refreshBtn = new Button();
            deleteBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)empGrid).BeginInit();
            SuspendLayout();
            // 
            // empGrid
            // 
            empGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            empGrid.Location = new Point(12, 12);
            empGrid.Name = "empGrid";
            empGrid.Size = new Size(765, 205);
            empGrid.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 254);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 1;
            label1.Text = "Employee ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 292);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 2;
            label2.Text = "Employee Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(123, 329);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 3;
            label3.Text = "Employee Salary";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(123, 370);
            label4.Name = "label4";
            label4.Size = new Size(125, 15);
            label4.TabIndex = 4;
            label4.Text = "Employee Department";
            // 
            // employeedDepartmentCb
            // 
            employeedDepartmentCb.FormattingEnabled = true;
            employeedDepartmentCb.Location = new Point(323, 362);
            employeedDepartmentCb.Name = "employeedDepartmentCb";
            employeedDepartmentCb.Size = new Size(121, 23);
            employeedDepartmentCb.TabIndex = 5;
            // 
            // employeeSalaryTxt
            // 
            employeeSalaryTxt.Location = new Point(323, 321);
            employeeSalaryTxt.Name = "employeeSalaryTxt";
            employeeSalaryTxt.Size = new Size(121, 23);
            employeeSalaryTxt.TabIndex = 6;
            // 
            // employeeNameTxt
            // 
            employeeNameTxt.Location = new Point(323, 284);
            employeeNameTxt.Name = "employeeNameTxt";
            employeeNameTxt.Size = new Size(121, 23);
            employeeNameTxt.TabIndex = 7;
            // 
            // employeeIdtxt
            // 
            employeeIdtxt.Location = new Point(323, 246);
            employeeIdtxt.Name = "employeeIdtxt";
            employeeIdtxt.Size = new Size(121, 23);
            employeeIdtxt.TabIndex = 8;
            // 
            // addNewBtn
            // 
            addNewBtn.Location = new Point(468, 290);
            addNewBtn.Name = "addNewBtn";
            addNewBtn.Size = new Size(75, 23);
            addNewBtn.TabIndex = 9;
            addNewBtn.Text = "Add New";
            addNewBtn.UseVisualStyleBackColor = true;
            addNewBtn.Click += addNewBtn_Click;
            // 
            // submitBtn
            // 
            submitBtn.Location = new Point(468, 319);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(75, 23);
            submitBtn.TabIndex = 10;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // selectBtn
            // 
            selectBtn.Location = new Point(549, 290);
            selectBtn.Name = "selectBtn";
            selectBtn.Size = new Size(123, 23);
            selectBtn.TabIndex = 11;
            selectBtn.Text = "Select to Update";
            selectBtn.UseVisualStyleBackColor = true;
            selectBtn.Click += selectBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(549, 319);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(123, 23);
            updateBtn.TabIndex = 12;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // refreshBtn
            // 
            refreshBtn.Location = new Point(678, 292);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(75, 23);
            refreshBtn.TabIndex = 13;
            refreshBtn.Text = "Refresh";
            refreshBtn.UseVisualStyleBackColor = true;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(678, 319);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(75, 23);
            deleteBtn.TabIndex = 14;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(deleteBtn);
            Controls.Add(refreshBtn);
            Controls.Add(updateBtn);
            Controls.Add(selectBtn);
            Controls.Add(submitBtn);
            Controls.Add(addNewBtn);
            Controls.Add(employeeIdtxt);
            Controls.Add(employeeNameTxt);
            Controls.Add(employeeSalaryTxt);
            Controls.Add(employeedDepartmentCb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(empGrid);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)empGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView empGrid;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox employeedDepartmentCb;
        private TextBox employeeSalaryTxt;
        private TextBox employeeNameTxt;
        private TextBox employeeIdtxt;
        private Button addNewBtn;
        private Button submitBtn;
        private Button selectBtn;
        private Button updateBtn;
        private Button refreshBtn;
        private Button deleteBtn;
    }
}
