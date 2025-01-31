namespace W3D4Assignment3._4
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
            dgCoffeeList = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            cbIsHot = new CheckBox();
            txtPrice = new TextBox();
            cbSugar = new ComboBox();
            cbMilk = new ComboBox();
            cbBeanType = new ComboBox();
            cbRoastLevel = new ComboBox();
            cbSize = new ComboBox();
            cbCoffeeName = new ComboBox();
            label8 = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgCoffeeList).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgCoffeeList
            // 
            dgCoffeeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCoffeeList.Location = new Point(22, 26);
            dgCoffeeList.Margin = new Padding(6, 6, 6, 6);
            dgCoffeeList.Name = "dgCoffeeList";
            dgCoffeeList.RowHeadersWidth = 82;
            dgCoffeeList.Size = new Size(1560, 909);
            dgCoffeeList.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 75);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(182, 36);
            label1.TabIndex = 1;
            label1.Text = "Coffee Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 154);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 36);
            label2.TabIndex = 2;
            label2.Text = "Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 230);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 36);
            label3.TabIndex = 3;
            label3.Text = "Size:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 316);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 36);
            label4.TabIndex = 4;
            label4.Text = "IsHot:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 403);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(158, 36);
            label5.TabIndex = 5;
            label5.Text = "Roast Level:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 489);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(148, 36);
            label6.TabIndex = 6;
            label6.Text = "Bean Type:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 576);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(77, 36);
            label7.TabIndex = 7;
            label7.Text = "Milk:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbIsHot);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(cbSugar);
            groupBox1.Controls.Add(cbMilk);
            groupBox1.Controls.Add(cbBeanType);
            groupBox1.Controls.Add(cbRoastLevel);
            groupBox1.Controls.Add(cbSize);
            groupBox1.Controls.Add(cbCoffeeName);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(1593, 26);
            groupBox1.Margin = new Padding(6, 6, 6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6, 6, 6, 6);
            groupBox1.Size = new Size(539, 759);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "New Order";
            // 
            // cbIsHot
            // 
            cbIsHot.AutoSize = true;
            cbIsHot.Location = new Point(277, 307);
            cbIsHot.Margin = new Padding(6, 6, 6, 6);
            cbIsHot.Name = "cbIsHot";
            cbIsHot.Size = new Size(122, 40);
            cbIsHot.TabIndex = 16;
            cbIsHot.Text = "IsHot?";
            cbIsHot.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(277, 137);
            txtPrice.Margin = new Padding(6, 6, 6, 6);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(221, 42);
            txtPrice.TabIndex = 15;
            txtPrice.Validating += txtPrice_Validating;
            // 
            // cbSugar
            // 
            cbSugar.FormattingEnabled = true;
            cbSugar.Location = new Point(277, 638);
            cbSugar.Margin = new Padding(6, 6, 6, 6);
            cbSugar.Name = "cbSugar";
            cbSugar.Size = new Size(221, 44);
            cbSugar.TabIndex = 14;
            // 
            // cbMilk
            // 
            cbMilk.FormattingEnabled = true;
            cbMilk.Location = new Point(277, 559);
            cbMilk.Margin = new Padding(6, 6, 6, 6);
            cbMilk.Name = "cbMilk";
            cbMilk.Size = new Size(221, 44);
            cbMilk.TabIndex = 13;
            // 
            // cbBeanType
            // 
            cbBeanType.FormattingEnabled = true;
            cbBeanType.Location = new Point(277, 471);
            cbBeanType.Margin = new Padding(6, 6, 6, 6);
            cbBeanType.Name = "cbBeanType";
            cbBeanType.Size = new Size(221, 44);
            cbBeanType.TabIndex = 12;
            // 
            // cbRoastLevel
            // 
            cbRoastLevel.FormattingEnabled = true;
            cbRoastLevel.Location = new Point(277, 386);
            cbRoastLevel.Margin = new Padding(6, 6, 6, 6);
            cbRoastLevel.Name = "cbRoastLevel";
            cbRoastLevel.Size = new Size(221, 44);
            cbRoastLevel.TabIndex = 11;
            // 
            // cbSize
            // 
            cbSize.FormattingEnabled = true;
            cbSize.Location = new Point(277, 213);
            cbSize.Margin = new Padding(6, 6, 6, 6);
            cbSize.Name = "cbSize";
            cbSize.Size = new Size(221, 44);
            cbSize.TabIndex = 10;
            // 
            // cbCoffeeName
            // 
            cbCoffeeName.FormattingEnabled = true;
            cbCoffeeName.Location = new Point(277, 58);
            cbCoffeeName.Margin = new Padding(6, 6, 6, 6);
            cbCoffeeName.Name = "cbCoffeeName";
            cbCoffeeName.Size = new Size(221, 44);
            cbCoffeeName.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 655);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(94, 36);
            label8.TabIndex = 8;
            label8.Text = "Sugar:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1593, 841);
            btnAdd.Margin = new Padding(6, 6, 6, 6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(243, 60);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1889, 841);
            btnDelete.Margin = new Padding(6, 6, 6, 6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(243, 60);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(2154, 960);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(groupBox1);
            Controls.Add(dgCoffeeList);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form1";
            Text = "Coffee Shop";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgCoffeeList).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgCoffeeList;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private GroupBox groupBox1;
        private Label label8;
        private ComboBox cbSugar;
        private ComboBox cbMilk;
        private ComboBox cbBeanType;
        private ComboBox cbRoastLevel;
        private ComboBox cbSize;
        private ComboBox cbCoffeeName;
        private CheckBox cbIsHot;
        private TextBox txtPrice;
        private Button btnAdd;
        private Button btnDelete;
    }
}
