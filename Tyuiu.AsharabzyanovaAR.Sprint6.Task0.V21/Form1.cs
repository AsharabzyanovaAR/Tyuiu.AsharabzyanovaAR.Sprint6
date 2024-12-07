using Tyuiu.AsharabzyanovaAR.Sprint6.Task0.V21.Lib;
namespace Tyuiu.AsharabzyanovaAR.Sprint6.Task0.V21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_AAR.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_AAR.Text)));

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarX_AAR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',' || e.KeyChar != 8))
            {
                e.Handled = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ПКТБ-24-1 Ашарабзянова Алина Рустамовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
