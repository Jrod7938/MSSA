using System.Text.Json;
using System.Xml.Serialization;


namespace W10D1Assignment10._1
{
    public partial class form : Form {
        List<Customer> Customers;
        string jsonPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), $"Customers-{DateTime.Now.DayOfYear}.json");
        string xmlPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), $"Customers-{DateTime.Now.DayOfYear}.xml");

        public form() {
            InitializeComponent();
            Customers = new List<Customer>();
        }

        private void addCustomerBtn_Click(object sender, EventArgs e) {
            Customers.Add(new Customer(firstNameTxt.Text, lastNameTxt.Text, addressTxt.Text, double.Parse(priceTxt.Text)));
            MessageBox.Show("Customer Added", "Success");
            firstNameTxt.Clear();
            lastNameTxt.Clear();
            addressTxt.Clear();
            priceTxt.Clear();
        }

        private void jsonSerializeBtn_Click(object sender, EventArgs e) {
            if (File.Exists(jsonPath)) File.Delete(jsonPath);

            FileStream jsonStream = new FileStream(jsonPath, FileMode.OpenOrCreate, FileAccess.Write);
            JsonSerializer.Serialize(jsonStream, Customers);
            jsonStream.Close();
            MessageBox.Show("Customers Serialized JSON", "Serialization Success");
        }

        private void jsonDeserializeBtn_Click(object sender, EventArgs e) {
            if(!File.Exists(jsonPath)) {
                MessageBox.Show("No Json File Found", "Failed");
                return;
            }

            FileStream jsonStream = new FileStream(jsonPath, FileMode.Open, FileAccess.Read);
            Customers = JsonSerializer.Deserialize<List<Customer>>(jsonStream);
            jsonStream.Close();

            string result = "Customers: \n\n";
            foreach(Customer customer in Customers) {
                result += $"Name: {customer.FirstName} {customer.LastName}\nAddress: {customer.Address}\nPrice: {customer.Price}\n\n";
            }

            MessageBox.Show(result);
        }

        private void xmlSerializeBtn_Click(object sender, EventArgs e) {
            if (File.Exists(xmlPath)) File.Delete(xmlPath);

            FileStream xmlStream = new FileStream(xmlPath, FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Customer>));
            xmlSerializer.Serialize(xmlStream, Customers);
            xmlStream.Close();
            MessageBox.Show("Customers Serialized XML", "Serialization Success");
        }

        private void xmlDeserializeBtn_Click(object sender, EventArgs e) {
            if (!File.Exists(xmlPath)) {
                MessageBox.Show("No XML File Found", "Failed");
                return;
            }

            FileStream xmlStream = new FileStream(xmlPath, FileMode.Open, FileAccess.Read);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Customer>));
            Customers = (List<Customer>)xmlSerializer.Deserialize(xmlStream);
            xmlStream.Close();

            string result = "Customers: \n\n";
            foreach (Customer customer in Customers) {
                result += $"Name: {customer.FirstName} {customer.LastName}\nAddress: {customer.Address}\nPrice: {customer.Price}\n\n";
            }

            MessageBox.Show(result);
        }
    }
}
