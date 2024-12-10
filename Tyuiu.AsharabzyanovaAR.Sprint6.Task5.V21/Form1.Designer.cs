namespace Tyuiu.AsharabzyanovaAR.Sprint6.Task5.V21
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxUsl_AAR = new GroupBox();
            labelUsl_AAR = new Label();
            buttonDone_AAR = new Button();
            buttonHeip_AAR = new Button();
            buttonSave_AAR = new Button();
            groupBox2 = new GroupBox();
            dataGridView_AAR = new DataGridView();
            chart_AAR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxUsl_AAR.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_AAR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart_AAR).BeginInit();
            SuspendLayout();
            // 
            // groupBoxUsl_AAR
            // 
            groupBoxUsl_AAR.Controls.Add(labelUsl_AAR);
            groupBoxUsl_AAR.Location = new Point(12, 12);
            groupBoxUsl_AAR.Name = "groupBoxUsl_AAR";
            groupBoxUsl_AAR.Size = new Size(552, 138);
            groupBoxUsl_AAR.TabIndex = 0;
            groupBoxUsl_AAR.TabStop = false;
            groupBoxUsl_AAR.Text = "Условие";
            // 
            // labelUsl_AAR
            // 
            labelUsl_AAR.AutoSize = true;
            labelUsl_AAR.Location = new Point(6, 23);
            labelUsl_AAR.Name = "labelUsl_AAR";
            labelUsl_AAR.Size = new Size(525, 100);
            labelUsl_AAR.TabIndex = 0;
            labelUsl_AAR.Text = resources.GetString("labelUsl_AAR.Text");
            // 
            // buttonDone_AAR
            // 
            buttonDone_AAR.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDone_AAR.BackColor = SystemColors.ActiveCaption;
            buttonDone_AAR.Location = new Point(625, 44);
            buttonDone_AAR.Name = "buttonDone_AAR";
            buttonDone_AAR.Size = new Size(99, 81);
            buttonDone_AAR.TabIndex = 1;
            buttonDone_AAR.Text = "Выполнить";
            buttonDone_AAR.UseVisualStyleBackColor = false;
            buttonDone_AAR.Click += buttonDone_AAR_Click;
            // 
            // buttonHeip_AAR
            // 
            buttonHeip_AAR.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHeip_AAR.BackColor = SystemColors.GrayText;
            buttonHeip_AAR.Location = new Point(758, 44);
            buttonHeip_AAR.Name = "buttonHeip_AAR";
            buttonHeip_AAR.Size = new Size(99, 81);
            buttonHeip_AAR.TabIndex = 2;
            buttonHeip_AAR.Text = "Справка";
            buttonHeip_AAR.UseVisualStyleBackColor = false;
            buttonHeip_AAR.Click += buttonHeip_AAR_Click;
            // 
            // buttonSave_AAR
            // 
            buttonSave_AAR.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSave_AAR.BackColor = SystemColors.MenuHighlight;
            buttonSave_AAR.Location = new Point(888, 44);
            buttonSave_AAR.Name = "buttonSave_AAR";
            buttonSave_AAR.Size = new Size(97, 81);
            buttonSave_AAR.TabIndex = 3;
            buttonSave_AAR.Text = "Открыть файл";
            buttonSave_AAR.UseVisualStyleBackColor = false;
            buttonSave_AAR.Click += buttonSave_AAR_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(dataGridView_AAR);
            groupBox2.Location = new Point(12, 156);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(206, 354);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных";
            // 
            // dataGridView_AAR
            // 
            dataGridView_AAR.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_AAR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_AAR.Location = new Point(6, 26);
            dataGridView_AAR.Name = "dataGridView_AAR";
            dataGridView_AAR.RowHeadersWidth = 51;
            dataGridView_AAR.Size = new Size(194, 322);
            dataGridView_AAR.TabIndex = 0;
            // 
            // chart_AAR
            // 
            chart_AAR.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chart_AAR.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart_AAR.Legends.Add(legend1);
            chart_AAR.Location = new Point(287, 172);
            chart_AAR.Name = "chart_AAR";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart_AAR.Series.Add(series1);
            chart_AAR.Size = new Size(680, 338);
            chart_AAR.TabIndex = 5;
            chart_AAR.Text = "chart1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 559);
            Controls.Add(chart_AAR);
            Controls.Add(groupBox2);
            Controls.Add(buttonSave_AAR);
            Controls.Add(buttonHeip_AAR);
            Controls.Add(buttonDone_AAR);
            Controls.Add(groupBoxUsl_AAR);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6|Таск 5|Вариант 21|Ашарабзянова А.Р.";
            groupBoxUsl_AAR.ResumeLayout(false);
            groupBoxUsl_AAR.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_AAR).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart_AAR).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUsl_AAR;
        private Label labelUsl_AAR;
        private Button buttonDone_AAR;
        private Button buttonHeip_AAR;
        private Button buttonSave_AAR;
        private GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_AAR;
        private DataGridView dataGridView_AAR;
    }
}
