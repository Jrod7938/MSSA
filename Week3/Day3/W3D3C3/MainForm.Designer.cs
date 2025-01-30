namespace W3D3C3 {
    partial class MainForm {
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
            lblEmployeePortal = new Label();
            empGrid = new DataGridView();
            btnAddEmployee = new Button();
            btnDeleteEmeployee = new Button();
            btRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)empGrid).BeginInit();
            SuspendLayout();
            // 
            // lblEmployeePortal
            // 
            lblEmployeePortal.AutoSize = true;
            lblEmployeePortal.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmployeePortal.Location = new Point(284, 25);
            lblEmployeePortal.Name = "lblEmployeePortal";
            lblEmployeePortal.Size = new Size(182, 30);
            lblEmployeePortal.TabIndex = 0;
            lblEmployeePortal.Text = "Employee Portal";
            // 
            // empGrid
            // 
            empGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            empGrid.Location = new Point(111, 108);
            empGrid.Name = "empGrid";
            empGrid.Size = new Size(545, 150);
            empGrid.TabIndex = 1;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddEmployee.Location = new Point(121, 331);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(155, 45);
            btnAddEmployee.TabIndex = 2;
            btnAddEmployee.Text = "Add Employee";
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // btnDeleteEmeployee
            // 
            btnDeleteEmeployee.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteEmeployee.Location = new Point(491, 331);
            btnDeleteEmeployee.Name = "btnDeleteEmeployee";
            btnDeleteEmeployee.Size = new Size(155, 45);
            btnDeleteEmeployee.TabIndex = 3;
            btnDeleteEmeployee.Text = "Delete Employee";
            btnDeleteEmeployee.UseVisualStyleBackColor = true;
            btnDeleteEmeployee.Click += btnDeleteEmeployee_Click;
            // 
            // btRefresh
            // 
            btRefresh.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btRefresh.Location = new Point(311, 331);
            btRefresh.Name = "btRefresh";
            btRefresh.Size = new Size(155, 45);
            btRefresh.TabIndex = 4;
            btRefresh.Text = "Refresh";
            btRefresh.UseVisualStyleBackColor = true;
            btRefresh.Click += btRefresh_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btRefresh);
            Controls.Add(btnDeleteEmeployee);
            Controls.Add(btnAddEmployee);
            Controls.Add(empGrid);
            Controls.Add(lblEmployeePortal);
            Name = "MainForm";
            Text = "Employee Portal";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)empGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmployeePortal;
        private DataGridView empGrid;
        private Button btnAddEmployee;
        private Button btnDeleteEmeployee;
        private Button btRefresh;
    }
}