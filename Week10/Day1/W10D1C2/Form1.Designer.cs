namespace W10D1C2
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
            IdTxt = new TextBox();
            nameTxt = new TextBox();
            addressTxt = new TextBox();
            gpaTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            serializeBtn = new Button();
            DeserializeBtn = new Button();
            xmlSerializeBtn = new Button();
            xmlDeserializeBtn = new Button();
            SuspendLayout();
            // 
            // IdTxt
            // 
            IdTxt.Location = new Point(439, 63);
            IdTxt.Name = "IdTxt";
            IdTxt.Size = new Size(100, 23);
            IdTxt.TabIndex = 0;
            // 
            // nameTxt
            // 
            nameTxt.Location = new Point(439, 129);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(100, 23);
            nameTxt.TabIndex = 1;
            // 
            // addressTxt
            // 
            addressTxt.Location = new Point(439, 197);
            addressTxt.Name = "addressTxt";
            addressTxt.Size = new Size(100, 23);
            addressTxt.TabIndex = 2;
            // 
            // gpaTxt
            // 
            gpaTxt.Location = new Point(439, 256);
            gpaTxt.Name = "gpaTxt";
            gpaTxt.Size = new Size(100, 23);
            gpaTxt.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(253, 71);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 4;
            label1.Text = "Student Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 137);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 5;
            label2.Text = "Student Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(253, 205);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 6;
            label3.Text = "Student Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(253, 264);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 7;
            label4.Text = "Student GPA";
            // 
            // button1
            // 
            button1.Location = new Point(324, 306);
            button1.Name = "button1";
            button1.Size = new Size(148, 23);
            button1.TabIndex = 8;
            button1.Text = "Create Student";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // serializeBtn
            // 
            serializeBtn.Location = new Point(253, 366);
            serializeBtn.Name = "serializeBtn";
            serializeBtn.Size = new Size(121, 23);
            serializeBtn.TabIndex = 9;
            serializeBtn.Text = "JSON Serialize";
            serializeBtn.UseVisualStyleBackColor = true;
            serializeBtn.Click += serializeBtn_Click;
            // 
            // DeserializeBtn
            // 
            DeserializeBtn.Location = new Point(253, 402);
            DeserializeBtn.Name = "DeserializeBtn";
            DeserializeBtn.Size = new Size(121, 23);
            DeserializeBtn.TabIndex = 10;
            DeserializeBtn.Text = "JSON Deserialize";
            DeserializeBtn.UseVisualStyleBackColor = true;
            DeserializeBtn.Click += DeserializeBtn_Click;
            // 
            // xmlSerializeBtn
            // 
            xmlSerializeBtn.Location = new Point(439, 366);
            xmlSerializeBtn.Name = "xmlSerializeBtn";
            xmlSerializeBtn.Size = new Size(100, 23);
            xmlSerializeBtn.TabIndex = 11;
            xmlSerializeBtn.Text = "XML Serialize";
            xmlSerializeBtn.UseVisualStyleBackColor = true;
            xmlSerializeBtn.Click += xmlSerializeBtn_Click;
            // 
            // xmlDeserializeBtn
            // 
            xmlDeserializeBtn.Location = new Point(439, 402);
            xmlDeserializeBtn.Name = "xmlDeserializeBtn";
            xmlDeserializeBtn.Size = new Size(100, 23);
            xmlDeserializeBtn.TabIndex = 12;
            xmlDeserializeBtn.Text = "XML Deserialize";
            xmlDeserializeBtn.UseVisualStyleBackColor = true;
            xmlDeserializeBtn.Click += xmlDeserializeBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(xmlDeserializeBtn);
            Controls.Add(xmlSerializeBtn);
            Controls.Add(DeserializeBtn);
            Controls.Add(serializeBtn);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gpaTxt);
            Controls.Add(addressTxt);
            Controls.Add(nameTxt);
            Controls.Add(IdTxt);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox IdTxt;
        private TextBox nameTxt;
        private TextBox addressTxt;
        private TextBox gpaTxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button serializeBtn;
        private Button DeserializeBtn;
        private Button xmlSerializeBtn;
        private Button xmlDeserializeBtn;
    }
}
