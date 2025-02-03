namespace W4D1Assignment4._1 {
    public partial class AddForm : Form {
        DataGridView dgData;
        public AddForm(DataGridView dataGrid) {
            InitializeComponent();
            dgData = dataGrid;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            new Person(txtFirstName.Text, 
                txtLastName.Text, 
                long.Parse(txtMobilePhone.Text), 
                long.Parse(txtWorkPhone.Text), 
                txtAddress.Text);
            dgData.DataSource = null;
            dgData.DataSource = PhoneBook.People.Values.ToList();
            this.Close();
        }

        private void txtFirstName_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (string.IsNullOrEmpty(txtFirstName.Text)) {
                MessageBox.Show("Please enter a First Name", "Incorrect Input");
                e.Cancel = true;
                txtFirstName.Clear();
            }
        }

        private void txtLastName_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (string.IsNullOrEmpty(txtLastName.Text)) {
                MessageBox.Show("Please enter a Last Name", "Incorrect Input");
                e.Cancel = true;
                txtLastName.Clear();
            }
        }

        private void txtMobilePhone_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (string.IsNullOrEmpty(txtMobilePhone.Text)) {
                MessageBox.Show("Please enter a mobile phone", "Incorrect Input");
                e.Cancel = true;
                txtMobilePhone.Clear();
            }

        }

        private void txtWorkPhone_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (string.IsNullOrEmpty(txtWorkPhone.Text)) {
                MessageBox.Show("Please enter a working phone", "Incorrect Input");
                e.Cancel = true;
                txtWorkPhone.Clear();
            }
        }

        private void txtAddress_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (string.IsNullOrEmpty(txtAddress.Text)) {
                MessageBox.Show("Please enter an address", "Incorrect Input");
                e.Cancel = true;
                txtAddress.Clear();
            }
        }
    }
}
