namespace W4D1C3
{
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            BankAccount bankAccount = new BankAccount();
            bankAccount.LowBalance += BankAccount_LowBalance;
            bankAccount.AccountNumber = int.Parse(txtAccountNumber.Text);
            bankAccount.AccountBalance = double.Parse(txtBalance.Text);
        }

        private void BankAccount_LowBalance(double bal) {
            MessageBox.Show($"Balance of {bal} is too low. Please enter more than 200.");
        }
    }
}
