using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W3D3C3.Util;
using W3D3C3.models;

namespace W3D3C3 {
    public partial class AddEmployeeForm : Form {
        public AddEmployeeForm() {
            InitializeComponent();
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e) {
            // reading all values from department enum and putting them into combo box
            cbEmployeeDepartment.DataSource = Enum.GetValues(typeof(Department));
        }

        private void btSubmit_Click(object sender, EventArgs e) {
            if (txtEmployeeId.Text != string.Empty && txtEmployeeName.Text != string.Empty) {
                Data.Employees.Add(new Employee() {
                    EmployeeId = int.Parse(txtEmployeeId.Text),
                    FullName = txtEmployeeName.Text,
                    Address = txtEmployeeAddress.Text,
                    Salary = double.Parse(txtEmployeeeSalary.Text),
                    Department = (Department)(cbEmployeeDepartment.SelectedIndex + 1)
                });
                MessageBox.Show("Record Added", "Success");

            }
        }

        private void txtEmployeeId_Validating(object sender, CancelEventArgs e) {
            if (txtEmployeeId.TextLength != 0) {
                int val;
                if (!int.TryParse(txtEmployeeId.Text, out val)) {
                    MessageBox.Show("Please enter digits only");
                    e.Cancel = true; // focus on the same textbox
                    txtEmployeeId.Clear();
                }
            } else if (int.Parse(txtEmployeeId.Text) <= 0) {
                MessageBox.Show("Please enter a positive Id");
                e.Cancel = true;
                txtEmployeeId.Clear();
            }
        }

        private void txtEmployeeeSalary_Validating(object sender, CancelEventArgs e) {
            if(txtEmployeeeSalary.TextLength!= 0) {
                if(!int.TryParse(txtEmployeeeSalary.Text, out int val)) {
                    MessageBox.Show("Please enter a number");
                    e.Cancel = true;
                    txtEmployeeeSalary.Clear();
                }
            }
        }
    }
}
