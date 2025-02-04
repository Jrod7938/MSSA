namespace W4D2Assignment4._2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public void btnLogin_Click(object sender, EventArgs e) {
            if (txtUserName.Text == "Teacher" && txtPassword.Text == "Admin") {
                AdminForm AdminForm = new AdminForm();
                AdminForm.Show();
            } else {
                MessageBox.Show("Login Failed");
                txtUserName.Clear();
                txtPassword.Clear();
            }
        }
    }
}
