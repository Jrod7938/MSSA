using W3D3Assignment3._3.models;
using W3D3Assignment3._3.View;

namespace W3D3Assignment3._3 {
    public partial class StudentRecords : Form {
        public StudentRecords() {
            InitializeComponent();
            Student.GenerateRecords();
        }

        private void StudentRecords_Load(object sender, EventArgs e) {
            dgStudentRecords.DataSource = Student.Students;
        }

        private void btnAddStudent_Click(object sender, EventArgs e) {
            AddStudent addStudent = new AddStudent();
            addStudent.Show();
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e) {
            var result = MessageBox.Show("Delete Student?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
                Student.Students.RemoveAt(dgStudentRecords.CurrentRow.Index);
                dgStudentRecords.DataSource = null;
                dgStudentRecords.DataSource = Student.Students;
            } else {
                return;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            dgStudentRecords.DataSource = null;
            dgStudentRecords.DataSource = Student.Students;
        }
    }
}
