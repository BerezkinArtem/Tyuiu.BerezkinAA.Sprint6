using Tyuiu.BerezkinAA.Sprint6.Task1.V14.Lib;
namespace Tyuiu.BerezkinAA.Sprint6.Task1.V14
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
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_BAA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_BAA.Text);

                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_BAA.Text = "";
                textBoxResult_BAA.AppendText("+---------+---------+" + Environment.NewLine);
                textBoxResult_BAA.AppendText("|    X    |   f(x)  |" + Environment.NewLine);
                textBoxResult_BAA.AppendText("+---------+---------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,7:d}  | {1, 7:f2} |", startStep, valueArray[i]);
                    textBoxResult_BAA.AppendText(strLine + Environment.NewLine);
                   startStep++;
                }
                textBoxResult_BAA.AppendText("+---------+---------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonHelp_BAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИСПб-24-1 Березкин Артем Андреевич", "Сообщение");
        }

        private void buttonHelp_BAA_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
