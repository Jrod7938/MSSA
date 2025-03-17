using System.IO;

namespace W10D1C1
{
    public partial class Form1 : Form {

        string filePath;

        public Form1() {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) {
            richTextArea.Clear();
            richTextArea.Focus();
            saveToolStripMenuItem.Enabled = true;
            saveAsToolStripMenuItem.Enabled = true;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text Files(*.txt)|*.txt";
            dialog.Title = "Open Text Files";
            dialog.ShowDialog();

            if (dialog.FileName != string.Empty) {
                filePath = dialog.FileName;
                richTextArea.Text = File.ReadAllText(filePath);
            }
            saveToolStripMenuItem.Enabled = true;
            saveAsToolStripMenuItem.Enabled = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            if (File.Exists(filePath)) {
                File.WriteAllText(filePath, richTextArea.Text);
            } else {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Text Files(*.txt)|*.txt";

                if (saveFile.ShowDialog() == DialogResult.OK) {
                    filePath = saveFile.FileName;
                    Stream stream = saveFile.OpenFile();
                    StreamWriter writer = new StreamWriter(stream);
                    writer.WriteLine(richTextArea.Text);
                    writer.Close();
                    stream.Close();
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text Files(*.txt)|*.txt";

            if (saveFile.ShowDialog() == DialogResult.OK) {
                filePath = saveFile.FileName;

                Stream stream = saveFile.OpenFile();
                StreamWriter writer = new StreamWriter(stream);
                writer.WriteLine(richTextArea.Text);
                writer.Close();
                stream.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e) {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowDialog();
            richTextArea.SelectionFont = fontDialog.Font;
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            richTextArea.SelectionColor = colorDialog.Color;
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e) {
            Clipboard.SetText(richTextArea.SelectedText);
            richTextArea.SelectedText = string.Empty;
        }
    }
}
