using Tyuiu.AsharabzyanovaAR.Sprint6.Task2.V12.Lib;

namespace Tyuiu.AsharabzyanovaAR.Sprint6.Task2.V12
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
                this.chartsin_AAR.Titles.Add("������ ������� sin(x)");
                this.chartsin_AAR.ChartAreas[0].AxisX.Title = "��� X";
                this.chartsin_AAR.ChartAreas[0].AxisX.Title = "��� Y";



                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridView_AAR.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartsin_AAR.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }


            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void buttonVopros_AAR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 2 ��������� ��������� ������ ����-24-1 ������������ ����� ����������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
