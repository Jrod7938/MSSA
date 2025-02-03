namespace W4D1C3
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
            label1 = new Label();
            txtAccountNumber = new TextBox();
            label2 = new Label();
            txtBalance = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(175, 115);
            label1.Name = "label1";
            label1.Size = new Size(142, 17);
            label1.TabIndex = 0;
            label1.Text = "BankAccount Number";
            // 
            // txtAccountNumber
            // 
            txtAccountNumber.Location = new Point(464, 107);
            txtAccountNumber.Name = "txtAccountNumber";
            txtAccountNumber.Size = new Size(100, 23);
            txtAccountNumber.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(175, 160);
            label2.Name = "label2";
            label2.Size = new Size(55, 17);
            label2.TabIndex = 2;
            label2.Text = "Balance";
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(464, 154);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(100, 23);
            txtBalance.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(316, 261);
            button1.Name = "button1";
            button1.Size = new Size(116, 23);
            button1.TabIndex = 4;
            button1.Text = "Create Account";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtBalance);
            Controls.Add(label2);
            Controls.Add(txtAccountNumber);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAccountNumber;
        private Label label2;
        private TextBox txtBalance;
        private Button button1;
    }
}
