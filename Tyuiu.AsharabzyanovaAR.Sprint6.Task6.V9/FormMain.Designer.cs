namespace Tyuiu.AsharabzyanovaAR.Sprint6.Task6.V9
{
    partial class Form_AAR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AAR));
            groupBoxUsl_AAR = new GroupBox();
            labelUsl_AAR = new Label();
            groupBoxVvod_AAR = new GroupBox();
            textBoxVvod_AAR = new TextBox();
            groupBoxVivod_AAR = new GroupBox();
            textBoxVivod_AAR = new TextBox();
            buttonOpen_AAR = new Button();
            buttonDone_AAR = new Button();
            buttonHelp_AAR = new Button();
            openFileDialogTask6_AAR = new OpenFileDialog();
            toolTipTask6_AAR = new ToolTip(components);
            panelTop_AAR = new Panel();
            splitContainer1 = new SplitContainer();
            groupBoxUsl_AAR.SuspendLayout();
            groupBoxVvod_AAR.SuspendLayout();
            groupBoxVivod_AAR.SuspendLayout();
            panelTop_AAR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxUsl_AAR
            // 
            groupBoxUsl_AAR.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxUsl_AAR.Controls.Add(labelUsl_AAR);
            groupBoxUsl_AAR.Location = new Point(21, 96);
            groupBoxUsl_AAR.Name = "groupBoxUsl_AAR";
            groupBoxUsl_AAR.Size = new Size(1196, 103);
            groupBoxUsl_AAR.TabIndex = 0;
            groupBoxUsl_AAR.TabStop = false;
            groupBoxUsl_AAR.Text = "Условие";
            // 
            // labelUsl_AAR
            // 
            labelUsl_AAR.AutoSize = true;
            labelUsl_AAR.Location = new Point(6, 23);
            labelUsl_AAR.Name = "labelUsl_AAR";
            labelUsl_AAR.Size = new Size(671, 60);
            labelUsl_AAR.TabIndex = 0;
            labelUsl_AAR.Text = resources.GetString("labelUsl_AAR.Text");
            // 
            // groupBoxVvod_AAR
            // 
            groupBoxVvod_AAR.Controls.Add(textBoxVvod_AAR);
            groupBoxVvod_AAR.Dock = DockStyle.Fill;
            groupBoxVvod_AAR.Location = new Point(0, 0);
            groupBoxVvod_AAR.Name = "groupBoxVvod_AAR";
            groupBoxVvod_AAR.Size = new Size(406, 513);
            groupBoxVvod_AAR.TabIndex = 1;
            groupBoxVvod_AAR.TabStop = false;
            groupBoxVvod_AAR.Text = "Ввод";
            // 
            // textBoxVvod_AAR
            // 
            textBoxVvod_AAR.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxVvod_AAR.Location = new Point(6, 26);
            textBoxVvod_AAR.Multiline = true;
            textBoxVvod_AAR.Name = "textBoxVvod_AAR";
            textBoxVvod_AAR.ScrollBars = ScrollBars.Vertical;
            textBoxVvod_AAR.Size = new Size(394, 481);
            textBoxVvod_AAR.TabIndex = 0;
            // 
            // groupBoxVivod_AAR
            // 
            groupBoxVivod_AAR.Controls.Add(textBoxVivod_AAR);
            groupBoxVivod_AAR.Dock = DockStyle.Fill;
            groupBoxVivod_AAR.Location = new Point(0, 0);
            groupBoxVivod_AAR.Name = "groupBoxVivod_AAR";
            groupBoxVivod_AAR.Size = new Size(810, 513);
            groupBoxVivod_AAR.TabIndex = 2;
            groupBoxVivod_AAR.TabStop = false;
            groupBoxVivod_AAR.Text = "Вывод";
            // 
            // textBoxVivod_AAR
            // 
            textBoxVivod_AAR.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxVivod_AAR.Location = new Point(6, 26);
            textBoxVivod_AAR.Multiline = true;
            textBoxVivod_AAR.Name = "textBoxVivod_AAR";
            textBoxVivod_AAR.ScrollBars = ScrollBars.Vertical;
            textBoxVivod_AAR.Size = new Size(798, 481);
            textBoxVivod_AAR.TabIndex = 0;
            // 
            // buttonOpen_AAR
            // 
            buttonOpen_AAR.BackgroundImage = (Image)resources.GetObject("buttonOpen_AAR.BackgroundImage");
            buttonOpen_AAR.Location = new Point(21, 11);
            buttonOpen_AAR.Name = "buttonOpen_AAR";
            buttonOpen_AAR.Size = new Size(106, 79);
            buttonOpen_AAR.TabIndex = 3;
            toolTipTask6_AAR.SetToolTip(buttonOpen_AAR, "\r\n.");
            buttonOpen_AAR.UseVisualStyleBackColor = true;
            buttonOpen_AAR.Click += buttonOpen_AAR_Click;
            // 
            // buttonDone_AAR
            // 
            buttonDone_AAR.BackgroundImage = (Image)resources.GetObject("buttonDone_AAR.BackgroundImage");
            buttonDone_AAR.Location = new Point(133, 8);
            buttonDone_AAR.Name = "buttonDone_AAR";
            buttonDone_AAR.Size = new Size(84, 84);
            buttonDone_AAR.TabIndex = 4;
            toolTipTask6_AAR.SetToolTip(buttonDone_AAR, "Выводит последнее слово каждой строки");
            buttonDone_AAR.UseVisualStyleBackColor = true;
            buttonDone_AAR.Click += buttonDone_AAR_Click;
            // 
            // buttonHelp_AAR
            // 
            buttonHelp_AAR.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_AAR.BackgroundImage = (Image)resources.GetObject("buttonHelp_AAR.BackgroundImage");
            buttonHelp_AAR.BackgroundImageLayout = ImageLayout.Zoom;
            buttonHelp_AAR.Location = new Point(1157, 8);
            buttonHelp_AAR.Name = "buttonHelp_AAR";
            buttonHelp_AAR.Size = new Size(48, 79);
            buttonHelp_AAR.TabIndex = 5;
            toolTipTask6_AAR.SetToolTip(buttonHelp_AAR, "О программе");
            buttonHelp_AAR.UseVisualStyleBackColor = true;
            buttonHelp_AAR.Click += buttonHelp_AAR_Click;
            // 
            // openFileDialogTask6_AAR
            // 
            openFileDialogTask6_AAR.FileName = "openFileDialog1";
            // 
            // panelTop_AAR
            // 
            panelTop_AAR.Controls.Add(buttonHelp_AAR);
            panelTop_AAR.Controls.Add(buttonOpen_AAR);
            panelTop_AAR.Controls.Add(buttonDone_AAR);
            panelTop_AAR.Controls.Add(groupBoxUsl_AAR);
            panelTop_AAR.Dock = DockStyle.Top;
            panelTop_AAR.Location = new Point(0, 0);
            panelTop_AAR.Name = "panelTop_AAR";
            panelTop_AAR.Size = new Size(1220, 201);
            panelTop_AAR.TabIndex = 1;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 201);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBoxVvod_AAR);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBoxVivod_AAR);
            splitContainer1.Size = new Size(1220, 513);
            splitContainer1.SplitterDistance = 406;
            splitContainer1.TabIndex = 2;
            // 
            // Form_AAR
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 714);
            Controls.Add(splitContainer1);
            Controls.Add(panelTop_AAR);
            MinimumSize = new Size(1238, 756);
            Name = "Form_AAR";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6|Таск 6|Вариант 9|Ашарабзянова А.Р.";
            toolTipTask6_AAR.SetToolTip(this, "Открыть файл.");
            groupBoxUsl_AAR.ResumeLayout(false);
            groupBoxUsl_AAR.PerformLayout();
            groupBoxVvod_AAR.ResumeLayout(false);
            groupBoxVvod_AAR.PerformLayout();
            groupBoxVivod_AAR.ResumeLayout(false);
            groupBoxVivod_AAR.PerformLayout();
            panelTop_AAR.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUsl_AAR;
        private Label labelUsl_AAR;
        private GroupBox groupBoxVvod_AAR;
        private TextBox textBoxVvod_AAR;
        private GroupBox groupBoxVivod_AAR;
        private TextBox textBoxVivod_AAR;
        private Button buttonOpen_AAR;
        private Button buttonDone_AAR;
        private Button buttonHelp_AAR;
        private OpenFileDialog openFileDialogTask6_AAR;
        private ToolTip toolTipTask6_AAR;
        private Panel panelTop_AAR;
        private SplitContainer splitContainer1;
    }
}
