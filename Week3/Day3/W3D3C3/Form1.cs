namespace W3D3C3
{
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            if(txtUserName.Text == "Admin" && txtPassword.Text == "root") {
                MessageBox.Show("Welcome Admin!");
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            } else {
                MessageBox.Show("Invalid Login.\nPlease try again.");
                txtPassword.Clear();
                txtUserName.Clear();
            }
        }
    }
}
