namespace Tyuiu.AsharabzyanovaAR.Sprint6.Task7.V5
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxUsl_AAR = new GroupBox();
            labelUsl_AAR = new Label();
            buttonOpen_AAR = new Button();
            buttonDone_AAR = new Button();
            buttonSave_AAR = new Button();
            buttonHelp_AAR = new Button();
            groupBoxVVod_AAR = new GroupBox();
            dataGridViewVvod_AAR = new DataGridView();
            groupBoxVivod_AAR = new GroupBox();
            dataGridViewVivod_AAR = new DataGridView();
            openFileDialogTask7 = new OpenFileDialog();
            toolTipTask7 = new ToolTip(components);
            saveFileDialogTask7 = new SaveFileDialog();
            panelTop_AAR = new Panel();
            splitContainer_AAR = new SplitContainer();
            groupBoxUsl_AAR.SuspendLayout();
            groupBoxVVod_AAR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVvod_AAR).BeginInit();
            groupBoxVivod_AAR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVivod_AAR).BeginInit();
            panelTop_AAR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer_AAR).BeginInit();
            splitContainer_AAR.Panel1.SuspendLayout();
            splitContainer_AAR.Panel2.SuspendLayout();
            splitContainer_AAR.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxUsl_AAR
            // 
            groupBoxUsl_AAR.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxUsl_AAR.Controls.Add(labelUsl_AAR);
            groupBoxUsl_AAR.Location = new Point(6, 84);
            groupBoxUsl_AAR.Name = "groupBoxUsl_AAR";
            groupBoxUsl_AAR.Size = new Size(1205, 121);
            groupBoxUsl_AAR.TabIndex = 0;
            groupBoxUsl_AAR.TabStop = false;
            groupBoxUsl_AAR.Text = "Условие";
            // 
            // labelUsl_AAR
            // 
            labelUsl_AAR.AutoSize = true;
            labelUsl_AAR.Location = new Point(6, 48);
            labelUsl_AAR.Name = "labelUsl_AAR";
            labelUsl_AAR.Size = new Size(1043, 60);
            labelUsl_AAR.TabIndex = 0;
            labelUsl_AAR.Text = resources.GetString("labelUsl_AAR.Text");
            // 
            // buttonOpen_AAR
            // 
            buttonOpen_AAR.BackgroundImage = (Image)resources.GetObject("buttonOpen_AAR.BackgroundImage");
            buttonOpen_AAR.Location = new Point(11, 8);
            buttonOpen_AAR.Name = "buttonOpen_AAR";
            buttonOpen_AAR.Size = new Size(33, 35);
            buttonOpen_AAR.TabIndex = 1;
            toolTipTask7.SetToolTip(buttonOpen_AAR, "Открыть файл.");
            buttonOpen_AAR.UseVisualStyleBackColor = true;
            buttonOpen_AAR.Click += buttonOpen_AAR_Click;
            // 
            // buttonDone_AAR
            // 
            buttonDone_AAR.BackgroundImage = (Image)resources.GetObject("buttonDone_AAR.BackgroundImage");
            buttonDone_AAR.Location = new Point(50, 8);
            buttonDone_AAR.Name = "buttonDone_AAR";
            buttonDone_AAR.Size = new Size(32, 34);
            buttonDone_AAR.TabIndex = 2;
            toolTipTask7.SetToolTip(buttonDone_AAR, "Выводит матрицу");
            buttonDone_AAR.UseVisualStyleBackColor = true;
            buttonDone_AAR.Click += buttonDone_AAR_Click;
            // 
            // buttonSave_AAR
            // 
            buttonSave_AAR.BackgroundImage = (Image)resources.GetObject("buttonSave_AAR.BackgroundImage");
            buttonSave_AAR.Location = new Point(88, 8);
            buttonSave_AAR.Name = "buttonSave_AAR";
            buttonSave_AAR.Size = new Size(33, 34);
            buttonSave_AAR.TabIndex = 3;
            toolTipTask7.SetToolTip(buttonSave_AAR, "Сохраняет матрицу в файл");
            buttonSave_AAR.UseVisualStyleBackColor = true;
            buttonSave_AAR.Click += buttonSave_AAR_Click;
            // 
            // buttonHelp_AAR
            // 
            buttonHelp_AAR.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_AAR.BackgroundImage = (Image)resources.GetObject("buttonHelp_AAR.BackgroundImage");
            buttonHelp_AAR.BackgroundImageLayout = ImageLayout.Center;
            buttonHelp_AAR.Location = new Point(1170, 8);
            buttonHelp_AAR.Name = "buttonHelp_AAR";
            buttonHelp_AAR.Size = new Size(32, 68);
            buttonHelp_AAR.TabIndex = 4;
            toolTipTask7.SetToolTip(buttonHelp_AAR, "Информация о разработчике");
            buttonHelp_AAR.UseVisualStyleBackColor = true;
            buttonHelp_AAR.Click += buttonHelp_AAR_Click;
            // 
            // groupBoxVVod_AAR
            // 
            groupBoxVVod_AAR.Controls.Add(dataGridViewVvod_AAR);
            groupBoxVVod_AAR.Dock = DockStyle.Fill;
            groupBoxVVod_AAR.Location = new Point(0, 0);
            groupBoxVVod_AAR.Name = "groupBoxVVod_AAR";
            groupBoxVVod_AAR.Size = new Size(586, 602);
            groupBoxVVod_AAR.TabIndex = 5;
            groupBoxVVod_AAR.TabStop = false;
            groupBoxVVod_AAR.Text = "Ввод";
            // 
            // dataGridViewVvod_AAR
            // 
            dataGridViewVvod_AAR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVvod_AAR.ColumnHeadersVisible = false;
            dataGridViewVvod_AAR.Dock = DockStyle.Fill;
            dataGridViewVvod_AAR.Location = new Point(3, 23);
            dataGridViewVvod_AAR.Name = "dataGridViewVvod_AAR";
            dataGridViewVvod_AAR.RowHeadersVisible = false;
            dataGridViewVvod_AAR.RowHeadersWidth = 51;
            dataGridViewVvod_AAR.Size = new Size(580, 576);
            dataGridViewVvod_AAR.TabIndex = 0;
            dataGridViewVvod_AAR.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBoxVivod_AAR
            // 
            groupBoxVivod_AAR.Controls.Add(dataGridViewVivod_AAR);
            groupBoxVivod_AAR.Dock = DockStyle.Fill;
            groupBoxVivod_AAR.Location = new Point(0, 0);
            groupBoxVivod_AAR.Name = "groupBoxVivod_AAR";
            groupBoxVivod_AAR.Size = new Size(624, 602);
            groupBoxVivod_AAR.TabIndex = 6;
            groupBoxVivod_AAR.TabStop = false;
            groupBoxVivod_AAR.Text = "Вывод";
            // 
            // dataGridViewVivod_AAR
            // 
            dataGridViewVivod_AAR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVivod_AAR.ColumnHeadersVisible = false;
            dataGridViewVivod_AAR.Dock = DockStyle.Fill;
            dataGridViewVivod_AAR.Location = new Point(3, 23);
            dataGridViewVivod_AAR.Name = "dataGridViewVivod_AAR";
            dataGridViewVivod_AAR.RowHeadersVisible = false;
            dataGridViewVivod_AAR.RowHeadersWidth = 51;
            dataGridViewVivod_AAR.Size = new Size(618, 576);
            dataGridViewVivod_AAR.TabIndex = 0;
            // 
            // openFileDialogTask7
            // 
            openFileDialogTask7.FileName = "openFileDialog1";
            // 
            // panelTop_AAR
            // 
            panelTop_AAR.Controls.Add(groupBoxUsl_AAR);
            panelTop_AAR.Controls.Add(buttonSave_AAR);
            panelTop_AAR.Controls.Add(buttonHelp_AAR);
            panelTop_AAR.Controls.Add(buttonOpen_AAR);
            panelTop_AAR.Controls.Add(buttonDone_AAR);
            panelTop_AAR.Dock = DockStyle.Top;
            panelTop_AAR.Location = new Point(0, 0);
            panelTop_AAR.Name = "panelTop_AAR";
            panelTop_AAR.Size = new Size(1214, 217);
            panelTop_AAR.TabIndex = 7;
            // 
            // splitContainer_AAR
            // 
            splitContainer_AAR.Dock = DockStyle.Fill;
            splitContainer_AAR.Location = new Point(0, 217);
            splitContainer_AAR.Name = "splitContainer_AAR";
            // 
            // splitContainer_AAR.Panel1
            // 
            splitContainer_AAR.Panel1.Controls.Add(groupBoxVVod_AAR);
            // 
            // splitContainer_AAR.Panel2
            // 
            splitContainer_AAR.Panel2.Controls.Add(groupBoxVivod_AAR);
            splitContainer_AAR.Size = new Size(1214, 602);
            splitContainer_AAR.SplitterDistance = 586;
            splitContainer_AAR.TabIndex = 8;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 819);
            Controls.Add(splitContainer_AAR);
            Controls.Add(panelTop_AAR);
            MinimumSize = new Size(1232, 861);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6|Таск 7|Вариант 5|Ашарабзянова А.Р.";
            groupBoxUsl_AAR.ResumeLayout(false);
            groupBoxUsl_AAR.PerformLayout();
            groupBoxVVod_AAR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewVvod_AAR).EndInit();
            groupBoxVivod_AAR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewVivod_AAR).EndInit();
            panelTop_AAR.ResumeLayout(false);
            splitContainer_AAR.Panel1.ResumeLayout(false);
            splitContainer_AAR.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer_AAR).EndInit();
            splitContainer_AAR.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUsl_AAR;
        private Label labelUsl_AAR;
        private Button buttonOpen_AAR;
        private Button buttonDone_AAR;
        private Button buttonSave_AAR;
        private Button buttonHelp_AAR;
        private GroupBox groupBoxVVod_AAR;
        private DataGridView dataGridViewVvod_AAR;
        private GroupBox groupBoxVivod_AAR;
        private DataGridView dataGridViewVivod_AAR;
        private OpenFileDialog openFileDialogTask7;
        private ToolTip toolTipTask7;
        private SaveFileDialog saveFileDialogTask7;
        private Panel panelTop_AAR;
        private SplitContainer splitContainer_AAR;
    }
}
