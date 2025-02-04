namespace W4D2Assignment4._1._2
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
            groupBox1 = new GroupBox();
            dgHistory = new DataGridView();
            groupBox2 = new GroupBox();
            btnClear = new Button();
            btnEqual = new Button();
            btnSubtract = new Button();
            btnPlus = new Button();
            btnDivide = new Button();
            btnMultiply = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btn0 = new Button();
            txtDisplay = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgHistory).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgHistory);
            groupBox1.Location = new Point(318, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(201, 310);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "History";
            // 
            // dgHistory
            // 
            dgHistory.BackgroundColor = Color.Gainsboro;
            dgHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgHistory.Location = new Point(6, 22);
            dgHistory.Name = "dgHistory";
            dgHistory.Size = new Size(189, 280);
            dgHistory.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(btnEqual);
            groupBox2.Controls.Add(btnSubtract);
            groupBox2.Controls.Add(btnPlus);
            groupBox2.Controls.Add(btnDivide);
            groupBox2.Controls.Add(btnMultiply);
            groupBox2.Controls.Add(btn9);
            groupBox2.Controls.Add(btn8);
            groupBox2.Controls.Add(btn7);
            groupBox2.Controls.Add(btn6);
            groupBox2.Controls.Add(btn5);
            groupBox2.Controls.Add(btn4);
            groupBox2.Controls.Add(btn3);
            groupBox2.Controls.Add(btn2);
            groupBox2.Controls.Add(btn1);
            groupBox2.Controls.Add(btn0);
            groupBox2.Controls.Add(txtDisplay);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 310);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Expression";
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(195, 115);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(97, 22);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEqual.Location = new Point(195, 92);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(97, 26);
            btnEqual.TabIndex = 15;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSubtract.Location = new Point(102, 92);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(97, 45);
            btnSubtract.TabIndex = 14;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPlus.Location = new Point(8, 92);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(97, 45);
            btnPlus.TabIndex = 13;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDivide.Location = new Point(195, 134);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(97, 45);
            btnDivide.TabIndex = 12;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMultiply.Location = new Point(102, 134);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(97, 45);
            btnMultiply.TabIndex = 11;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn9.Location = new Point(8, 134);
            btn9.Name = "btn9";
            btn9.Size = new Size(97, 45);
            btn9.TabIndex = 10;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn8.Location = new Point(195, 174);
            btn8.Name = "btn8";
            btn8.Size = new Size(97, 45);
            btn8.TabIndex = 9;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn7.Location = new Point(102, 174);
            btn7.Name = "btn7";
            btn7.Size = new Size(97, 45);
            btn7.TabIndex = 8;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn6.Location = new Point(8, 174);
            btn6.Name = "btn6";
            btn6.Size = new Size(97, 45);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn5.Location = new Point(195, 215);
            btn5.Name = "btn5";
            btn5.Size = new Size(97, 45);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn4.Location = new Point(102, 215);
            btn4.Name = "btn4";
            btn4.Size = new Size(97, 45);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn3.Location = new Point(8, 215);
            btn3.Name = "btn3";
            btn3.Size = new Size(97, 45);
            btn3.TabIndex = 4;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn2.Location = new Point(195, 257);
            btn2.Name = "btn2";
            btn2.Size = new Size(97, 45);
            btn2.TabIndex = 3;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn1.Location = new Point(102, 257);
            btn1.Name = "btn1";
            btn1.Size = new Size(97, 45);
            btn1.TabIndex = 2;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn0.Location = new Point(8, 257);
            btn0.Name = "btn0";
            btn0.Size = new Size(97, 45);
            btn0.TabIndex = 1;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(8, 33);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(286, 39);
            txtDisplay.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 328);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Calculator App";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgHistory).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtDisplay;
        private Button btnEqual;
        private Button btnSubtract;
        private Button btnPlus;
        private Button btnDivide;
        private Button btnMultiply;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btn0;
        private DataGridView dgHistory;
        private Button btnClear;
    }
}
