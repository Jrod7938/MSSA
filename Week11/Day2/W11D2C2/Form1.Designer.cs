namespace W11D2C2
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
            moviesGrid = new DataGridView();
            btnAdd = new Button();
            btnGetWeather = new Button();
            ((System.ComponentModel.ISupportInitialize)moviesGrid).BeginInit();
            SuspendLayout();
            // 
            // moviesGrid
            // 
            moviesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            moviesGrid.Location = new Point(12, 12);
            moviesGrid.Name = "moviesGrid";
            moviesGrid.Size = new Size(776, 241);
            moviesGrid.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(212, 340);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(88, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add Movie";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnGetWeather
            // 
            btnGetWeather.Location = new Point(501, 340);
            btnGetWeather.Name = "btnGetWeather";
            btnGetWeather.Size = new Size(88, 23);
            btnGetWeather.TabIndex = 2;
            btnGetWeather.Text = "Get Weather";
            btnGetWeather.UseVisualStyleBackColor = true;
            btnGetWeather.Click += btnGetWeather_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGetWeather);
            Controls.Add(btnAdd);
            Controls.Add(moviesGrid);
            Name = "Form1";
            Text = "Client";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)moviesGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView moviesGrid;
        private Button btnAdd;
        private Button btnGetWeather;
    }
}
