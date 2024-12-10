using Tyuiu.AsharabzyanovaAR.Sprint6.Task5.V21.Lib;
namespace Tyuiu.AsharabzyanovaAR.Sprint6.Task5.V21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = Path.Combine(@"D:\Рабочий Стол\t\Tyuiu.AsharabzyanovaAR.Sprint6\Tyuiu.AsharabzyanovaAR.Sprint6.Task5.V21\bin\Debug\net8.0-windows\InPutDataFileTask5V21.txt");

        private void buttonDone_AAR_Click(object sender, EventArgs e)
        {
            dataGridView_AAR.ColumnCount = 2;
            dataGridView_AAR.Columns[0].Width = 20;
            dataGridView_AAR.Columns[1].Width = 50;

            chart_AAR.ChartAreas[0].AxisX.Title = "Ось X";
            chart_AAR.ChartAreas[0].AxisY.Title = "Ось Y";
            chart_AAR.Series[0].Points.Clear();

            double[] valueArray = new double[ds.len];

            valueArray = ds.LoadFromDataFile(path);

            for (int i = 0; i < valueArray.Length; i++)
            {
                dataGridView_AAR.Rows.Add(Convert.ToString(i), Convert.ToString(valueArray[i]));
                chart_AAR.Series[0].Points.AddXY(i, valueArray[i]);
            }
        }

        private void buttonSave_AAR_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHeip_AAR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы ПКТБ-24-1 Ашарабзянова Алина Рустамовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
