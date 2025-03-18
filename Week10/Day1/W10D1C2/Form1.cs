using System.Text.Json;
using System.Xml.Serialization;

namespace W10D1C2
{
    public partial class Form1 : Form {
        Student student;
        string jsonPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Student.json");
        string xmlPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Student.xml");

        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            student = new Student();
            student.Id = int.Parse(IdTxt.Text);
            student.Name = nameTxt.Text;
            student.Address = addressTxt.Text;
            student.GPA = float.Parse(gpaTxt.Text);

            MessageBox.Show("Student Created");

        }

        private void serializeBtn_Click(object sender, EventArgs e) {
            if (File.Exists(jsonPath)) File.Delete(jsonPath);

            FileStream jsonStream = new FileStream(jsonPath, FileMode.OpenOrCreate, FileAccess.Write);
            JsonSerializer.Serialize(jsonStream, student);
            jsonStream.Close();
            MessageBox.Show("Object is serialized");
        }

        private void DeserializeBtn_Click(object sender, EventArgs e) {
            FileStream jsonStream = new FileStream(jsonPath, FileMode.Open, FileAccess.Read);
            var obj = JsonSerializer.Deserialize<Student>(jsonStream);
            MessageBox.Show($"Student Name: {obj.Name}\nStudent GPA: {obj.GPA}");
            jsonStream.Close();
        }

        private void xmlSerializeBtn_Click(object sender, EventArgs e) {
            if (File.Exists(xmlPath)) File.Delete(xmlPath);

            FileStream xmlStream = new FileStream(xmlPath, FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
            xmlSerializer.Serialize(xmlStream, student);
            xmlStream.Close();
            MessageBox.Show("Student is serialized");
        }

        private void xmlDeserializeBtn_Click(object sender, EventArgs e) {
            FileStream xmlStream = new FileStream(xmlPath, FileMode.Open, FileAccess.Read);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));

            var obj = (Student)xmlSerializer.Deserialize(xmlStream);

            xmlStream.Close();
            MessageBox.Show($"Student Name: {obj.Name}\nStudent Id: {obj.Id}\nStudent GPA: {obj.GPA}");
        }
    }
}
