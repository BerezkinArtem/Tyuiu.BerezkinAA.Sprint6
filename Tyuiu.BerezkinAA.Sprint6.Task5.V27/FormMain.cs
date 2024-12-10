using System.Diagnostics;
using System.Globalization;
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

            this.chart_BAA.ChartAreas[0].AxisX.Title = "Îñü X";
            this.chart_BAA.ChartAreas[0].AxisY.Title = "Îñü Y";

            chart_BAA.Series[0].Points.Clear();

            double[] numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridView_BAA.Rows.Add(Convert.ToString(i), numsMass[i].ToString("F2", CultureInfo.InvariantCulture));
                chart_BAA.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpen_BAA_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo("notepad.exe", path) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Файл находится в: {ex.Message}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_BAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИСПб-24-1 Березкин Артем Андреевич", "Сообщение");
        }
    }
}