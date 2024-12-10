using Tyuiu.BerezkinAA.Sprint6.Task3.V25.Lib;
namespace Tyuiu.BerezkinAA.Sprint6.Task3.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = {     {14, 5, -9, 18, 21 },
                              {-5, -12, -12, 4, 28 },
                              {27, -2, -14, 23, 27 },
                              {-19, -15, 17, 15, 1 },
                              {33, 2, 6, 24, 24 } };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            dataGridViewMatrix_BAA.RowCount = rows;
            dataGridViewMatrix_BAA.ColumnCount = columns;

            for (int i = 0; i < rows; i++)
            {
                dataGridViewMatrix_BAA.Columns[i].Width = 40;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_BAA.Rows[i].Cells[j].Value = matrix[i, j].ToString();
                }
            }
        }



        private void buttonStart_BAA_Click(object sender, EventArgs e)
        {
            int[,] mtrx = ds.Calculate(matrix);
            int rows = mtrx.GetLength(0);
            int columns = mtrx.GetLength(1);

            dataGridViewMatrix_BAA.RowCount = rows;
            dataGridViewMatrix_BAA.ColumnCount = columns;

            for (int i = 0; i < rows; i++)
            {
                dataGridViewMatrix_BAA.Columns[i].Width = 40;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_BAA.Rows[i].Cells[j].Value = mtrx[i, j].ToString();
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonHelp_BAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 3 �������� ������� ������ ����-24-1 �������� ����� ���������", "���������");
        }

        private void dataGridViewMatrix_BAA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
