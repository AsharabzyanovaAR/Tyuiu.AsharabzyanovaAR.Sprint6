using Tyuiu.AsharabzyanovaAR.Sprint6.Task3.V28.Lib;

namespace Tyuiu.AsharabzyanovaAR.Sprint6.Task3.V28
{
    public partial class FormSprint6_AAR : Form
    {
        public FormSprint6_AAR()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5]{{-9,8,9,16,-18},
                                  {-13,-11,-20,-15,9},
                                  {18,13,-12,-15,-11},
                                  {10,-2,19,-4,-10},
                                  {6,-20,-4,13,-14} };

        private void buttonDone_AAR_Click(object sender, EventArgs e)
        {
            
            int[,] res = { };
            res = ds.Calculate(mtrx);
            int rows = res.GetUpperBound(0) + 1;
            int columns = res.Length / rows;

            dataGridViewRES_AAR.ColumnCount = columns;
            dataGridViewRES_AAR.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewRES_AAR.Columns[i].Width = 50;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewRES_AAR.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);

                }
            }


        }

        private void FormSprint6_AAR_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewmTRX_AAR.ColumnCount = columns;
            dataGridViewmTRX_AAR.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewmTRX_AAR.Columns[i].Width = 50;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewmTRX_AAR.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);

                }
            }

        }

        private void buttonInfa_AAR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы ПКТБ-24-1 Ашарабзянова Алина Рустамовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

       
    }
}
