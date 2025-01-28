using System;
using System.Windows.Forms;

namespace W3D2C3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void txtPassword_Changed(object sender, EventArgs e) {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e) {
            
        }

        private void btLogin_Click(object sender, EventArgs e) {
            if(txtUserName.Text == "Admin" && txtPassword.Text == "root") {
                MessageBox.Show("Successful Login");
                Console.WriteLine($"Successful Login username:{txtUserName.Text} password:{txtPassword.Text}");
            } else {
                MessageBox.Show("Incorrect Login");
                Console.WriteLine($"Failed login username:{txtUserName.Text} password:{txtPassword.Text}");
                txtUserName.Clear();
                txtPassword.Clear();
            }
 
            
        }
    }
}
