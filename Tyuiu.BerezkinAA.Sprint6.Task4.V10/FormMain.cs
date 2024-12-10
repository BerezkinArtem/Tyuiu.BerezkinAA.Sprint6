using Tyuiu.BerezkinAA.Sprint6.Task4.V10.Lib;
namespace Tyuiu.BerezkinAA.Sprint6.Task4.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonStart_BAA_Click(object sender, EventArgs e)
        {
            int startValue = Convert.ToInt32(textBoxStart_BAA.Text);
            int stopValue = Convert.ToInt32(textBoxStop_BAA.Text);
            int len = ds.GetMassFunction(startValue, stopValue).Length;
            double[] res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            this.chart1.ChartAreas[0].AxisX.Title = "Ось X";
            this.chart1.ChartAreas[0].AxisY.Title = "Ось Y";
            textBoxResult_BAA.Text = "";
            for (int i = 0; i <= len - 1; i++)
            {
                this.chart1.Series[0].Points.AddXY(startValue, res[i]);
                textBoxResult_BAA.AppendText(res[i] + Environment.NewLine);
                startValue++;
            }
        }

        private void buttonHelp_BAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИСПб-24-1 Березкин Артем Андреевич", "Сообщение");
        }

        private void buttonSave_BAA_Click(object sender, EventArgs e)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V10.txt";
            File.WriteAllText(path, textBoxResult_BAA.Text);

            DialogResult dialogResult = MessageBox.Show("Файл " + path + " Сохранен успешно! \n Открыть его в блокноте?",
                "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
        }
    }
}