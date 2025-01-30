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

namespace W3D3C3 {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            empGrid.DataSource = Data.Employees;
            empGrid.Columns[3].DisplayIndex = 1;
        }

        private void btnDeleteEmeployee_Click(object sender, EventArgs e) {
            var result = MessageBox.Show("Delete Employee?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
                Data.Employees.RemoveAt(empGrid.CurrentRow.Index);
                empGrid.DataSource = null;
                empGrid.DataSource = Data.Employees;
            } else {
                return;
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e) {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.ShowDialog();
        }

        private void btRefresh_Click(object sender, EventArgs e) {
            empGrid.DataSource = null;
            empGrid.DataSource = Data.Employees;
        }
    }
}
