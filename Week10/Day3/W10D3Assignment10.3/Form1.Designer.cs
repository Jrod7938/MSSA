namespace W10D3Assignment10._3
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
            carDg = new DataGridView();
            SelectBtn = new Button();
            deleteBtn = new Button();
            createBtn = new Button();
            submitBtn = new Button();
            updateBtn = new Button();
            RefreshBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtCarID = new TextBox();
            txtVin = new TextBox();
            txtMake = new TextBox();
            txtModel = new TextBox();
            txtYear = new TextBox();
            txtPrice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)carDg).BeginInit();
            SuspendLayout();
            // 
            // carDg
            // 
            carDg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            carDg.Location = new Point(12, 12);
            carDg.Name = "carDg";
            carDg.Size = new Size(776, 206);
            carDg.TabIndex = 0;
            // 
            // SelectBtn
            // 
            SelectBtn.Location = new Point(551, 235);
            SelectBtn.Name = "SelectBtn";
            SelectBtn.Size = new Size(75, 23);
            SelectBtn.TabIndex = 1;
            SelectBtn.Text = "Select";
            SelectBtn.UseVisualStyleBackColor = true;
            SelectBtn.Click += SelectBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(551, 281);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(75, 23);
            deleteBtn.TabIndex = 2;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // createBtn
            // 
            createBtn.Location = new Point(632, 235);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(75, 23);
            createBtn.TabIndex = 3;
            createBtn.Text = "Create";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click;
            // 
            // submitBtn
            // 
            submitBtn.Location = new Point(632, 281);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(75, 23);
            submitBtn.TabIndex = 4;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(713, 235);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(75, 23);
            updateBtn.TabIndex = 5;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // RefreshBtn
            // 
            RefreshBtn.Location = new Point(713, 281);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(75, 23);
            RefreshBtn.TabIndex = 6;
            RefreshBtn.Text = "Refresh";
            RefreshBtn.UseVisualStyleBackColor = true;
            RefreshBtn.Click += RefreshBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 245);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 7;
            label1.Text = "Car ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 289);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 8;
            label2.Text = "Vin: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(200, 244);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 9;
            label3.Text = "Make:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(200, 289);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 10;
            label4.Text = "Model:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(378, 244);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 11;
            label5.Text = "Year:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(378, 289);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 12;
            label6.Text = "Price:";
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(81, 236);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(100, 23);
            txtCarID.TabIndex = 13;
            // 
            // txtVin
            // 
            txtVin.Location = new Point(81, 281);
            txtVin.Name = "txtVin";
            txtVin.Size = new Size(100, 23);
            txtVin.TabIndex = 14;
            // 
            // txtMake
            // 
            txtMake.Location = new Point(250, 236);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(100, 23);
            txtMake.TabIndex = 15;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(250, 281);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(100, 23);
            txtModel.TabIndex = 16;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(426, 237);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(100, 23);
            txtYear.TabIndex = 17;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(426, 281);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 320);
            Controls.Add(txtPrice);
            Controls.Add(txtYear);
            Controls.Add(txtModel);
            Controls.Add(txtMake);
            Controls.Add(txtVin);
            Controls.Add(txtCarID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(RefreshBtn);
            Controls.Add(updateBtn);
            Controls.Add(submitBtn);
            Controls.Add(createBtn);
            Controls.Add(deleteBtn);
            Controls.Add(SelectBtn);
            Controls.Add(carDg);
            Name = "Form1";
            Text = "Cars";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)carDg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView carDg;
        private Button SelectBtn;
        private Button deleteBtn;
        private Button createBtn;
        private Button submitBtn;
        private Button updateBtn;
        private Button RefreshBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtCarID;
        private TextBox txtVin;
        private TextBox txtMake;
        private TextBox txtModel;
        private TextBox txtYear;
        private TextBox txtPrice;
    }
}
