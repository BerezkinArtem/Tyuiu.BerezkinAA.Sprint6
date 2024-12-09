using Tyuiu.BerezkinAA.Sprint6.Task2.V14.Lib;
namespace Tyuiu.BerezkinAA.Sprint6.Task2.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonStop_BAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИСПб-24-1 Березкин Артем Андреевич", "Сообщение");
        }

        private void buttonStart_BAA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_BAA.Text);
                int stopStep = Convert.ToInt32(textBoxStop_BAA.Text);


                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                //    this.chartFunction.Titles.Add("График функции sin(x)");
                //    this.chartFunction.Areas[0].AxisX.Title = "Ось Х";
                //    this.chartFunction.Areas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_BAA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    //        this.chartFunction.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void buttonStart_BAA_MouseEnter(object sender, EventArgs e)
        {
            buttonStart_BAA.BackColor = Color.Red;
        }

        private void buttonStart_BAA_MouseLeave(object sender, EventArgs e)
        {
            buttonStart_BAA.BackColor = Color.LightGreen;
        }

        private void buttonStart_BAA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonStart_BAA.BackColor = Color.LightBlue;
        }
    }

}
