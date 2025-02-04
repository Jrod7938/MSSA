using System.Text;

namespace W4D2Assignment4._1._2
{
    public partial class Form1 : Form {
        private StringBuilder operations = new StringBuilder();
        public Form1() {
            InitializeComponent();
            RefreshData();
        }

        private void RefreshData() {
            dgHistory.DataSource = null;
            dgHistory.DataSource = Maths.History;
            txtDisplay.Text = operations.ToString();
        }

        private void btn0_Click(object sender, EventArgs e) {
            operations.Append(0);
            RefreshData();
        }

        private void btn1_Click(object sender, EventArgs e) {
            operations.Append(1);
            RefreshData();
        }

        private void btn2_Click(object sender, EventArgs e) {
            operations.Append(2);
            RefreshData();
        }

        private void btn3_Click(object sender, EventArgs e) {
            operations.Append(3);
            RefreshData();
        }

        private void btn4_Click(object sender, EventArgs e) {
            operations.Append(4);
            RefreshData();
        }

        private void btn5_Click(object sender, EventArgs e) {
            operations.Append(5);
            RefreshData();
        }

        private void btn6_Click(object sender, EventArgs e) {
            operations.Append(6);
            RefreshData();
        }

        private void btn7_Click(object sender, EventArgs e) {
            operations.Append(7);
            RefreshData();
        }

        private void btn8_Click(object sender, EventArgs e) {
            operations.Append(8);
            RefreshData();
        }

        private void btn9_Click(object sender, EventArgs e) {
            operations.Append(9);
            RefreshData();
        }

        private void btnMultiply_Click(object sender, EventArgs e) {
            operations.Append($" * ");
            RefreshData();
        }

        private void btnDivide_Click(object sender, EventArgs e) {
            operations.Append($" / ");
            RefreshData();
        }

        private void btnPlus_Click(object sender, EventArgs e) {
            operations.Append($" + ");
            RefreshData();
        }

        private void btnSubtract_Click(object sender, EventArgs e) {
            operations.Append($" - ");
            RefreshData();
        }

        private void btnClear_Click(object sender, EventArgs e) {
            operations.Clear();
            RefreshData();
        }

        private void btnEqual_Click(object sender, EventArgs e) {
            int num1 = int.Parse(operations.ToString().Split(' ')[0]);
            int num2 = int.Parse(operations.ToString().Split(' ')[2]);
            string operation = operations.ToString().Split(' ')[1];
            Maths maths = new Maths();
            double result = 0;
            switch (operation) {
                case "+":
                    result = maths.Add(num1, num2);
                    break;
                case "-":
                    result = maths.Subtract(num1, num2);
                    break;
                case "*":
                    result = maths.Multiply(num1, num2);
                    break;
                case "/":
                    if (num2 == 0) {
                        MessageBox.Show("Cannot divide by zero");
                        return;
                    }
                    result = maths.Divide(num1, num2);
                    break;
            }
            operations.Append($" = {result}");
            HistoryEntry historyEntry = new HistoryEntry(operations.ToString());
            RefreshData();
        }
    }
}
