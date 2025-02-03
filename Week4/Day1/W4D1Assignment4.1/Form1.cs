namespace W4D1Assignment4._1
{
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            PhoneBook.GeneratePeople();
            RefreshData();
        }

        private void Form1_Load(object sender, EventArgs e) {
            RefreshData();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            AddForm addForm = new AddForm(dgPhoneBook);
            addForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            var result = MessageBox.Show("Delete Person?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
                PhoneBook.People.Remove($"{dgPhoneBook.CurrentRow.Cells[0].Value} {dgPhoneBook.CurrentRow.Cells[1].Value}");
                RefreshData();
            } else {
                return;
            }
        }

        private void RefreshData() {
            dgPhoneBook.DataSource = null;
            dgPhoneBook.DataSource = PhoneBook.People.Values.ToList();
        }
 

        private void btnSearch_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(txtSearch.Text.Trim())) {
                if (PhoneBook.People.ContainsKey(txtSearch.Text.Trim())) {
                    dgPhoneBook.DataSource = null;
                    dgPhoneBook.DataSource = new List<Person> { PhoneBook.People[txtSearch.Text] };
                } else {
                    MessageBox.Show("Person Not Found", "Search Result");
                    RefreshData();
                }
                txtSearch.Clear();
            }
        }
    }
}
