using System.IO;
using Tyuiu.BerezkinAA.Sprint6.Task6.V29.Lib;
namespace Tyuiu.BerezkinAA.Sprint6.Task6.V29
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        string path;
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonStart_BAA_Click(object sender, EventArgs e)
        {
            textBoxOutput_BAA.Text = ds.CollectTextFromFile(path);
        }

        private void buttonLoad_BAA_Click(object sender, EventArgs e)
        {
            openFileDialog_BAA.ShowDialog();
            path = openFileDialog_BAA.FileName;
            textBoxInput_BAA.Text = File.ReadAllText(path);
            groupBoxInput_BAA.Text = groupBoxInput_BAA.Text + " " + path;
            buttonStart_BAA.Enabled = true;
        }

        private void buttonHelp_BAA_Click(object sender, EventArgs e)
        {
            FormAbout fa = new FormAbout();
            fa.ShowDialog();
        }
    }
}