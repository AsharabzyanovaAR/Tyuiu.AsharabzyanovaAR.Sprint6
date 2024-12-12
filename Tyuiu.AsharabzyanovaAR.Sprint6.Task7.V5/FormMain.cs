using Tyuiu.AsharabzyanovaAR.Sprint6.Task7.V5.Lib;
namespace Tyuiu.AsharabzyanovaAR.Sprint6.Task7.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask7.Filter = "Значения, разделенные запятыми (*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogTask7.Filter = "Значения, разделенные запятыми (*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        DataService dataService = new DataService();
        static int rows;
        static int columns;
        static string? openFilePath;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDone_AAR_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = dataService.GetMatrix(openFilePath);
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewVivod_AAR.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_AAR.Enabled = true;
        }
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, columns];
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;


        }

        private void buttonHelp_AAR_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();

        }

        private void buttonOpen_AAR_Click(object sender, EventArgs e)
        {
            openFileDialogTask7.ShowDialog();
            openFilePath = openFileDialogTask7.FileName;
            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewVivod_AAR.ColumnCount = columns;
            dataGridViewVivod_AAR.RowCount = rows;
            dataGridViewVvod_AAR.ColumnCount = columns;
            dataGridViewVvod_AAR.RowCount = rows;
            dataGridViewVvod_AAR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewVivod_AAR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewVvod_AAR.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = dataService.GetMatrix(openFilePath);
            buttonDone_AAR.Enabled = true;


        }

        private void buttonSave_AAR_Click(object sender, EventArgs e)
        {
            saveFileDialogTask7.FileName = "OutPutFileTask7.csv";
            saveFileDialogTask7.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask7.ShowDialog();

            string path = saveFileDialogTask7.FileName;

            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                File.Delete(path);
            }

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewVivod_AAR.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewVivod_AAR.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
    }
}
