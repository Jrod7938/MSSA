using System.ComponentModel;
using W3D3Assignment3._3.models;

namespace W3D3Assignment3._3.View {
    public partial class AddStudent : Form {
        public AddStudent() {
            InitializeComponent();
        }

        private void AddStudent_Load(object sender, EventArgs e) {
            cbMonthofAdmission.DataSource = Enum.GetValues(typeof(MonthOfAdmission));
            cbGrade.DataSource = Enum.GetValues(typeof(Grade));
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e) {
            if (txtFirstName.Text.Length <= 0) {
                MessageBox.Show("Please enter the student's first name", "Warning");
                e.Cancel = true;
                txtFirstName.Clear();
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e) {
            if (txtLastName.Text.Length <= 0) {
                MessageBox.Show("Please enter the student's last name", "Warning");
                e.Cancel = true;
                txtLastName.Clear();
            }
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e) {
            if (txtAddress.Text.Length <= 0) {
                MessageBox.Show("Please enter the student's address", "Warning");
                e.Cancel = true;
                txtAddress.Clear();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e) {
            Student.Students.Add(new Student(
                txtFirstName.Text,
                txtLastName.Text,
                txtAddress.Text,
                (MonthOfAdmission)(cbMonthofAdmission.SelectedIndex + 1),
                (Grade)(cbGrade.SelectedIndex + 1)));
            MessageBox.Show("Student Added", "Success");
            this.Close();
        }
    }
}
