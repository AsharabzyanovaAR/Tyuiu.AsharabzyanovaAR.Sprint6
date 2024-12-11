using Tyuiu.AsharabzyanovaAR.Sprint6.Task6.V9.Lib;
namespace Tyuiu.AsharabzyanovaAR.Sprint6.Task6.V9
{
    public partial class Form_AAR : Form
    {
        public Form_AAR()
        {
            InitializeComponent();
            textBoxVivod_AAR.ScrollBars = ScrollBars.Vertical;
            textBoxVvod_AAR.ScrollBars = ScrollBars.Vertical;
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonDone_AAR_Click(object sender, EventArgs e)
        {
            string str = "";
            textBoxVivod_AAR.Text = ds.CollectTextFromFile(str, openFilePath);

        }

        private void buttonOpen_AAR_Click(object sender, EventArgs e)
        {
            openFileDialogTask6_AAR.ShowDialog();
            openFilePath = openFileDialogTask6_AAR.FileName;
            try
            {
                textBoxVvod_AAR.Text = File.ReadAllText(openFilePath);
                groupBoxVvod_AAR.Text = groupBoxVvod_AAR.Text + " " + openFileDialogTask6_AAR.FileName;
                buttonDone_AAR.Enabled = true;
            }
            catch
            {
                MessageBox.Show("¬ведены неверные данные", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonHelp_AAR_Click(object sender, EventArgs e)
        {

            FormAbout_AAR formAbout_AAR = new FormAbout_AAR();
            formAbout_AAR.ShowDialog();
        }
    }
}
