using W3D4Assignment3._4.models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace W3D4Assignment3._4
{
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            Coffee.GenerateData();
        }

        private void Form1_Load(object sender, EventArgs e) {
            RefreshData();

            cbCoffeeName.DataSource = Enum.GetValues(typeof(CoffeeName));
            cbSize.DataSource = Enum.GetValues(typeof(DrinkSize));
            cbRoastLevel.DataSource = Enum.GetValues(typeof(RoastLevel));
            cbBeanType.DataSource = Enum.GetValues(typeof(BeanType));
            cbMilk.DataSource = Enum.GetValues(typeof(Milk));
            cbSugar.DataSource = Enum.GetValues(typeof(Sugar));
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (txtPrice.Text.Length > 0) {
                Coffee.CoffeeList.Add(new Coffee(
                    cbCoffeeName.Text,
                    double.Parse(txtPrice.Text),
                    Enum.Parse<DrinkSize>(cbSize.Text),
                    cbIsHot.Checked,
                    Enum.Parse<RoastLevel>(cbRoastLevel.Text),
                    Enum.Parse<BeanType>(cbBeanType.Text),
                    Enum.Parse<Milk>(cbMilk.Text),
                    Enum.Parse<Sugar>(cbSugar.Text)));
                RefreshData();
            }
        }

        private void txtPrice_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (txtPrice.Text.Length != 0) {
                if (!double.TryParse(txtPrice.Text, out double val)) {
                    MessageBox.Show("Please Enter a double for price");
                    e.Cancel = true;
                    txtPrice.Clear();
                } else if (double.Parse(txtPrice.Text) <= 0) {
                    MessageBox.Show("Please Enter a positive value for price");
                    e.Cancel = true;
                    txtPrice.Clear();
                }
            } 
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            var result = MessageBox.Show("Delete Coffee?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
                Coffee.CoffeeList.RemoveAt(dgCoffeeList.CurrentRow.Index);
                RefreshData();
            } else {
                return;
            }
        }

        private void RefreshData() {
            dgCoffeeList.DataSource = null;
            dgCoffeeList.DataSource = Coffee.CoffeeList;
            dgCoffeeList.Columns[4].DisplayIndex = 0;
        }
    }
}
