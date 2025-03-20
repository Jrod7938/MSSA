using W10D3Assignment10._3.Models;
using W10D3Assignment10._3.Services;

namespace W10D3Assignment10._3
{
    public partial class Form1 : Form {
        CRUD CRUD { get; set; }
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            CRUD = new CRUD();
            carDg.DataSource = CRUD.GetCars();
            submitBtn.Enabled = false;
            updateBtn.Enabled = false;
        }

        private void createBtn_Click(object sender, EventArgs e) {
            Clear();
            txtCarID.Text = (CRUD.GetMaxId() + 1).ToString();
            txtCarID.ReadOnly = true;
            submitBtn.Enabled = true;
        }

        private void submitBtn_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(txtMake.Text) && !string.IsNullOrEmpty(txtModel.Text) && !string.IsNullOrEmpty(txtPrice.Text) && !string.IsNullOrEmpty(txtVin.Text) && !string.IsNullOrEmpty(txtYear.Text)) {
                CRUD.AddRecord(
                    new Car() {
                        CarID = int.Parse(txtCarID.Text),
                        Make = txtMake.Text,
                        Model = txtModel.Text,
                        Price = double.Parse(txtPrice.Text),
                        Vin = long.Parse(txtVin.Text),
                        Year = int.Parse(txtYear.Text)
                    }
                );
                Refresh();
                MessageBox.Show("Record Added", "Success");
            }
            submitBtn.Enabled = false;
        }

        private void RefreshBtn_Click(object sender, EventArgs e) {
            carDg.DataSource = null;

        }

        private void Refresh() {
            carDg.DataSource = CRUD.GetCars();
            Clear();
        }

        private void Clear() {
            txtCarID.Clear();
            txtMake.Clear();
            txtModel.Clear();
            txtPrice.Clear();
            txtVin.Clear();
            txtYear.Clear();
        }

        private void deleteBtn_Click(object sender, EventArgs e) {
            var id = carDg.CurrentRow.Cells[0].Value;
            CRUD.DeleteRecord((int)id);
            Refresh();
            MessageBox.Show("Record Deleted", "Success");
        }

        private void SelectBtn_Click(object sender, EventArgs e) {
            var id = carDg.CurrentRow.Cells[0].Value;
            var carToUpdate = CRUD.FindCar((int)id);
            txtCarID.Text = carToUpdate.CarID.ToString();
            txtCarID.ReadOnly = true;
            txtMake.Text = carToUpdate.Make;
            txtModel.Text = carToUpdate.Model;
            txtPrice.Text = carToUpdate.Price.ToString();
            txtVin.Text = carToUpdate.Vin.ToString();
            txtYear.Text = carToUpdate.Year.ToString();
            updateBtn.Enabled = true;
        }

        private void updateBtn_Click(object sender, EventArgs e) {
            var id = carDg.CurrentRow.Cells[0].Value;
            var carToUpdate = CRUD.FindCar((int)id);
            carToUpdate.Vin = long.Parse(txtVin.Text);
            carToUpdate.Make = txtMake.Text;
            carToUpdate.Model = txtModel.Text;
            carToUpdate.Price = double.Parse(txtPrice.Text);
            carToUpdate.Year = int.Parse(txtYear.Text);
            CRUD.UpdateRecord((int)id, carToUpdate);
            Refresh();
            MessageBox.Show("Record Updated", "Success");
            updateBtn.Enabled = false;
        }
    }
}
