namespace W10D1Assignment10._1
{
    partial class form
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
            addCustomerBtn = new Button();
            jsonSerializeBtn = new Button();
            jsonDeserializeBtn = new Button();
            xmlSerializeBtn = new Button();
            xmlDeserializeBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            firstNameTxt = new TextBox();
            lastNameTxt = new TextBox();
            addressTxt = new TextBox();
            priceTxt = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // addCustomerBtn
            // 
            addCustomerBtn.Location = new Point(107, 189);
            addCustomerBtn.Name = "addCustomerBtn";
            addCustomerBtn.Size = new Size(130, 23);
            addCustomerBtn.TabIndex = 0;
            addCustomerBtn.Text = "Add Customer";
            addCustomerBtn.UseVisualStyleBackColor = true;
            addCustomerBtn.Click += addCustomerBtn_Click;
            // 
            // jsonSerializeBtn
            // 
            jsonSerializeBtn.Location = new Point(12, 218);
            jsonSerializeBtn.Name = "jsonSerializeBtn";
            jsonSerializeBtn.Size = new Size(130, 23);
            jsonSerializeBtn.TabIndex = 1;
            jsonSerializeBtn.Text = "JSON Serialize";
            jsonSerializeBtn.UseVisualStyleBackColor = true;
            jsonSerializeBtn.Click += jsonSerializeBtn_Click;
            // 
            // jsonDeserializeBtn
            // 
            jsonDeserializeBtn.Location = new Point(12, 247);
            jsonDeserializeBtn.Name = "jsonDeserializeBtn";
            jsonDeserializeBtn.Size = new Size(130, 23);
            jsonDeserializeBtn.TabIndex = 2;
            jsonDeserializeBtn.Text = "JSON Deserialize";
            jsonDeserializeBtn.UseVisualStyleBackColor = true;
            jsonDeserializeBtn.Click += jsonDeserializeBtn_Click;
            // 
            // xmlSerializeBtn
            // 
            xmlSerializeBtn.Location = new Point(192, 218);
            xmlSerializeBtn.Name = "xmlSerializeBtn";
            xmlSerializeBtn.Size = new Size(130, 23);
            xmlSerializeBtn.TabIndex = 3;
            xmlSerializeBtn.Text = "XML Serialize";
            xmlSerializeBtn.UseVisualStyleBackColor = true;
            xmlSerializeBtn.Click += xmlSerializeBtn_Click;
            // 
            // xmlDeserializeBtn
            // 
            xmlDeserializeBtn.Location = new Point(192, 247);
            xmlDeserializeBtn.Name = "xmlDeserializeBtn";
            xmlDeserializeBtn.Size = new Size(130, 23);
            xmlDeserializeBtn.TabIndex = 4;
            xmlDeserializeBtn.Text = "XML Deserialize";
            xmlDeserializeBtn.UseVisualStyleBackColor = true;
            xmlDeserializeBtn.Click += xmlDeserializeBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(36, 49);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 5;
            label1.Text = "FirstName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(37, 83);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 6;
            label2.Text = "LastName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(37, 121);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 7;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(37, 157);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 8;
            label4.Text = "Price";
            // 
            // firstNameTxt
            // 
            firstNameTxt.Location = new Point(192, 41);
            firstNameTxt.Name = "firstNameTxt";
            firstNameTxt.Size = new Size(100, 23);
            firstNameTxt.TabIndex = 9;
            // 
            // lastNameTxt
            // 
            lastNameTxt.Location = new Point(192, 75);
            lastNameTxt.Name = "lastNameTxt";
            lastNameTxt.Size = new Size(100, 23);
            lastNameTxt.TabIndex = 10;
            // 
            // addressTxt
            // 
            addressTxt.Location = new Point(192, 113);
            addressTxt.Name = "addressTxt";
            addressTxt.Size = new Size(100, 23);
            addressTxt.TabIndex = 11;
            // 
            // priceTxt
            // 
            priceTxt.Location = new Point(192, 149);
            priceTxt.Name = "priceTxt";
            priceTxt.Size = new Size(100, 23);
            priceTxt.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(139, 9);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 13;
            label5.Text = "Customer";
            // 
            // form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 286);
            Controls.Add(label5);
            Controls.Add(priceTxt);
            Controls.Add(addressTxt);
            Controls.Add(lastNameTxt);
            Controls.Add(firstNameTxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(xmlDeserializeBtn);
            Controls.Add(xmlSerializeBtn);
            Controls.Add(jsonDeserializeBtn);
            Controls.Add(jsonSerializeBtn);
            Controls.Add(addCustomerBtn);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "form";
            Text = "Daily Sales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addCustomerBtn;
        private Button jsonSerializeBtn;
        private Button jsonDeserializeBtn;
        private Button xmlSerializeBtn;
        private Button xmlDeserializeBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox firstNameTxt;
        private TextBox lastNameTxt;
        private TextBox addressTxt;
        private TextBox priceTxt;
        private Label label5;
    }
}
