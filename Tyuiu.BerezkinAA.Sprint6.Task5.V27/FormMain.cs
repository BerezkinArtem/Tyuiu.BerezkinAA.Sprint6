using Tyuiu.BerezkinAA.Sprint6.Task5.V27.Lib;
namespace Tyuiu.BerezkinAA.Sprint6.Task5.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\DataSprint5\InPutDataFileTask5V27.txt";
        private void buttonStart_BAA_Click(object sender, EventArgs e)
        {
            dataGridView_BAA.ColumnCount = 2;
            dataGridView_BAA.Columns[0].Width = 20;
            dataGridView_BAA.Columns[1].Width = 50;
            chart_BAA.Series[0].Points.Clear();
            double[] mass = new double[ds.len];
            mass = ds.LoadFromDataFile(path);
            for (int i = 0; i < mass.Length; i++)
            {
                dataGridView_BAA.Rows.Add(Convert.ToString(i), Convert.ToString(mass[i]));
                chart_BAA.Series[0].Points.AddXY(i, mass[i]);
            }
        }

        private void buttonHelp_BAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИСПб-24-1 Березкин Артем Андреевич", "Сообщение");
        }

        private void buttonOpen_BAA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}