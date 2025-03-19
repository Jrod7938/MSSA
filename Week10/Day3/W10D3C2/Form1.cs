using W10D3C2.Models;
using W10D3C2.Services;

namespace W10D3C2
{
    public partial class Form1 : Form {

        CRUD CRUD { get; set; }

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            CRUD = new CRUD();
            empGrid.DataSource = CRUD.GetEmployees();
            empGrid.Columns[4].Visible = false;
            submitBtn.Enabled = false;
            updateBtn.Enabled = false;

            foreach (var d in CRUD.GetDepartments()) {
                employeedDepartmentCb.Items.Add(d);
            }
        }

        private void addNewBtn_Click(object sender, EventArgs e) {
            employeeIdtxt.Text = (CRUD.GetMaxId() + 1).ToString();
            employeeIdtxt.ReadOnly = true;
            employeeNameTxt.Clear();
            employeeSalaryTxt.Clear();
            submitBtn.Enabled = true;
        }

        private void submitBtn_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(employeeIdtxt.Text) && !string.IsNullOrEmpty(employeeNameTxt.Text)) {
                if (employeedDepartmentCb.SelectedIndex != -1) {
                    var newEmployee = new Employee();
                    newEmployee.EmpId = int.Parse(employeeIdtxt.Text);
                    newEmployee.Name = employeeNameTxt.Text;
                    newEmployee.Salary = double.Parse(employeeSalaryTxt.Text);
                    newEmployee.DepartmentID = employeedDepartmentCb.SelectedIndex + 1;
                    CRUD.AddRecord(newEmployee);
                    Refresh();
                    MessageBox.Show("Record Added");
                }
            }
            submitBtn.Enabled = false;
        }

        private void refreshBtn_Click(object sender, EventArgs e) {
            empGrid.DataSource = null;
            Refresh();
        }

        private void Refresh() {
            empGrid.DataSource = CRUD.GetEmployees();
            empGrid.Columns[4].Visible = false;
            Clear();
        }

        private void deleteBtn_Click(object sender, EventArgs e) {
            var id = empGrid.CurrentRow.Cells[0].Value;
            CRUD.DeleteRecord((int)id);
            Refresh();
            MessageBox.Show("Record Deleted");
        }

        private void selectBtn_Click(object sender, EventArgs e) {
            var id = empGrid.CurrentRow.Cells[0].Value;
            var employeeToUpdate = CRUD.FindEmployee((int)id);
            employeeIdtxt.Text = employeeToUpdate.EmpId.ToString();
            employeeIdtxt.ReadOnly = true;
            employeeNameTxt.Text = employeeToUpdate.Name;
            employeeSalaryTxt.Text = employeeToUpdate.Salary.ToString();
            employeedDepartmentCb.SelectedIndex = employeeToUpdate.DepartmentID - 1;
            updateBtn.Enabled = true;
        }

        private void updateBtn_Click(object sender, EventArgs e) {
            var id = int.Parse(employeeIdtxt.Text);
            var employeeToUpdate = CRUD.FindEmployee((int)id);
            employeeToUpdate.Name = employeeNameTxt.Text;
            employeeToUpdate.Salary = double.Parse(employeeSalaryTxt.Text);
            employeeToUpdate.DepartmentID = employeedDepartmentCb.SelectedIndex + 1;
            CRUD.UpdateRecord(id, employeeToUpdate);
            Refresh();
            MessageBox.Show("Record Updated");
            updateBtn.Enabled = false;
        }

        private void Clear() {
            employeeIdtxt.Clear();
            employeeNameTxt.Clear();
            employeeSalaryTxt.Clear();
            employeedDepartmentCb.SelectedIndex = -1;
        }
    }
}
