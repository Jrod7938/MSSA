using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W4D2Assignment4._2 {
    public partial class AdminForm : Form {
        public AdminForm() {
            InitializeComponent();
            Student.GenerateStudents();
            RefreshData();
        }

        private void button1_Click(object sender, EventArgs e) {
            new Student(txtName.Text, Convert.ToDecimal(nudGPA.Value));
            RefreshData();
        }

        private void RefreshData() {
            dgStudents.DataSource = null;
            dgStudents.DataSource = Student.Students;
        }

        private void txtName_Validating(object sender, CancelEventArgs e) {
            if (txtName.Text.Length == 0) {
                MessageBox.Show("Name is required");
                e.Cancel = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            Student.Students.RemoveAt(dgStudents.CurrentRow.Index);
            RefreshData();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if(Student.Students.Count == 0) {
                MessageBox.Show("No students to save");
                return;
            }
            Student topStudent = Student.Students.OrderDescending().First();
            string PATH = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "TopStudent.txt");
            string DATA = $"{topStudent.Name} has the highest GPA of {topStudent.GPA}";
            File.WriteAllText(PATH, DATA);
            MessageBox.Show("Top student saved to My Documents");
        }
    }
}
