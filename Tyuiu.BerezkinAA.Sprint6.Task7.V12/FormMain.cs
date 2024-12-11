using Tyuiu.BerezkinAA.Sprint6.Task7.V12.Lib;
namespace Tyuiu.BerezkinAA.Sprint6.Task7.V12
{
    public partial class FormMain : Form
    {

        DataService ds = new();
        static int rows;
        static int cols;
        static string path;
        public static int[,] mtr(string path)
        {
            string data = File.ReadAllText(path);
            data = data.Replace('\n', '\r');
            string[] lines = data.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            cols = lines[0].Split(';').Length;


            int[,] arr = new int[rows, cols];
            for (int r = 0; r < rows; r++)
            {
                string[] linr = lines[r].Split(';');
                for (int c = 0; c < cols; c++)
                {
                    arr[r, c] = Convert.ToInt32(linr[c]);
                }
            }
            return arr;
        }
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_BAA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog_BAA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonInfo_BAA_Click(object sender, EventArgs e)
        {
            FormAbout fa = new FormAbout();
            fa.ShowDialog();
        }

        private void buttonOpen_BAA_Click(object sender, EventArgs e)
        {
            {
                openFileDialog_BAA.ShowDialog();
                path = openFileDialog_BAA.FileName;
                openFileDialog_BAA.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog_BAA.Title = "Выберите файл";
                int[,] arr = new int[rows, cols];
                arr = mtr(path);
                DataGridViewInPut_BAA.ColumnCount = cols;
                DataGridViewOutPut_BAA.ColumnCount = cols;
                DataGridViewInPut_BAA.RowCount = rows;
                DataGridViewOutPut_BAA.RowCount = rows;
                for (int i = 0; i < cols; i++)
                {
                    DataGridViewInPut_BAA.Columns[i].Width = 25;
                    DataGridViewOutPut_BAA.Columns[i].Width = 25;
                }
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        DataGridViewInPut_BAA.Rows[r].Cells[c].Value = arr[r, c];
                    }
                }
            }
        }

        private void buttonStart_BAA_Click(object sender, EventArgs e)
        {
            {
                int[,] arr = new int[rows, cols];
                arr = ds.GetMatrix(path);
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        DataGridViewOutPut_BAA.Rows[r].Cells[c].Value = arr[r, c];
                    }
                }
            }
        }

        private void buttonSave_BAA_Click(object sender, EventArgs e)
        {
            {
                saveFileDialog_BAA.FileName = "OutPutTask7.csv";
                saveFileDialog_BAA.InitialDirectory = Directory.GetCurrentDirectory();
                saveFileDialog_BAA.ShowDialog();

                string path1 = saveFileDialog_BAA.FileName;
                FileInfo fi = new FileInfo(path1);
                bool fe = fi.Exists;
                if (fe)
                {
                    File.Delete(path1);
                }
                string str = "";
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (j != cols - 1)
                        {
                            str = str + DataGridViewOutPut_BAA.Rows[i].Cells[j].Value + ";";
                        }
                        else
                        {
                            str = str + DataGridViewOutPut_BAA.Rows[i].Cells[j].Value;
                        }
                    }
                    File.AppendAllText(path1, str + Environment.NewLine);
                    str = "";
                }

            }

        }
    }

}