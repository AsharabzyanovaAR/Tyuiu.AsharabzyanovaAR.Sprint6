using Tyuiu.AsharabzyanovaAR.Sprint6.Task4.V3.Lib;
namespace Tyuiu.AsharabzyanovaAR.Sprint6.Task4.V3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_AAR_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_AAR.Text);
                int stopStep = Convert.ToInt32(textBoxStop_AAR.Text);



                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartsin_AAR.Titles.Add("График функции sin(x)");
                this.chartsin_AAR.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartsin_AAR.ChartAreas[0].AxisX.Title = "Ось Y";
                textBoxRes_AAR.Text = " ";
                chartsin_AAR.Series[0].Points.Clear();
                for (int i = 0; i <= len; i++)
                {
                    this.chartsin_AAR.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxRes_AAR.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }




            }


            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void buttonVopros_AAR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка группы ПКТБ-24-1 Ашарабзянова Алина Рустамовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void buttonSoxr_AAR_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxRes_AAR.Text);
                DialogResult dialogResult = MessageBox.Show("Файл" + path + "сохранен успешно\nОткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void buttonSpravka_AAR_Click(object sender, EventArgs e)
        {

        }
    }
}
