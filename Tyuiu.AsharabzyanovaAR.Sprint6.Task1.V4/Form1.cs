using Tyuiu.AsharabzyanovaAR.Sprint6.Task1.V4.Lib;
namespace Tyuiu.AsharabzyanovaAR.Sprint6.Task1.V4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_AAR.Text);
                int stopStep = Convert.ToInt32(textBoxStop_AAR.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxRes_AAR.Text = "";
                textBoxRes_AAR.AppendText("+-------------+------------+" + Environment.NewLine);
                textBoxRes_AAR.AppendText("|      X      |     f(x)   |" + Environment.NewLine);
                textBoxRes_AAR.AppendText("+-------------+------------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 5:f2}     |", startStep, valueArray[i]);
                    textBoxRes_AAR.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxRes_AAR.AppendText("+-------------+------------+");

            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonHeLP_AAR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 1 ��������� ��������� ������ ����-24-1 ������������ ����� ����������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
