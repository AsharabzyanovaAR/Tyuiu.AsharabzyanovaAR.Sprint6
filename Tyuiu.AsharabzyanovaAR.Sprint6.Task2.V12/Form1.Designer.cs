namespace Tyuiu.AsharabzyanovaAR.Sprint6.Task2.V12
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxUsl_AAR = new GroupBox();
            labelU_AAR = new Label();
            labelUsl_AAR = new Label();
            groupBoxVivod_AAR = new GroupBox();
            chartsin_AAR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridView_AAR = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            labelres_AAR = new Label();
            groupBoxVvod_AAR = new GroupBox();
            textBoxStop_AAR = new TextBox();
            textBoxStart_AAR = new TextBox();
            labelStop_AAR = new Label();
            labelStart_AAR = new Label();
            buttonDone_AAR = new Button();
            buttonVopros_AAR = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBoxUsl_AAR.SuspendLayout();
            groupBoxVivod_AAR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartsin_AAR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_AAR).BeginInit();
            groupBoxVvod_AAR.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxUsl_AAR
            // 
            groupBoxUsl_AAR.Controls.Add(labelU_AAR);
            groupBoxUsl_AAR.Controls.Add(labelUsl_AAR);
            groupBoxUsl_AAR.Location = new Point(12, 12);
            groupBoxUsl_AAR.Name = "groupBoxUsl_AAR";
            groupBoxUsl_AAR.Size = new Size(570, 290);
            groupBoxUsl_AAR.TabIndex = 0;
            groupBoxUsl_AAR.TabStop = false;
            // 
            // labelU_AAR
            // 
            labelU_AAR.AutoSize = true;
            labelU_AAR.Location = new Point(6, 53);
            labelU_AAR.Name = "labelU_AAR";
            labelU_AAR.Size = new Size(474, 40);
            labelU_AAR.TabIndex = 1;
            labelU_AAR.Text = "Протабулировать значение функции sin(x) в заданном диапозоне.\r\nРезультат вывести в DataGrfdView и построить график функции\r\n";
            // 
            // labelUsl_AAR
            // 
            labelUsl_AAR.AutoSize = true;
            labelUsl_AAR.Location = new Point(6, 23);
            labelUsl_AAR.Name = "labelUsl_AAR";
            labelUsl_AAR.Size = new Size(67, 20);
            labelUsl_AAR.TabIndex = 0;
            labelUsl_AAR.Text = "Условие";
            // 
            // groupBoxVivod_AAR
            // 
            groupBoxVivod_AAR.Controls.Add(chartsin_AAR);
            groupBoxVivod_AAR.Controls.Add(dataGridView_AAR);
            groupBoxVivod_AAR.Controls.Add(labelres_AAR);
            groupBoxVivod_AAR.Location = new Point(588, 12);
            groupBoxVivod_AAR.Name = "groupBoxVivod_AAR";
            groupBoxVivod_AAR.Size = new Size(606, 426);
            groupBoxVivod_AAR.TabIndex = 1;
            groupBoxVivod_AAR.TabStop = false;
            groupBoxVivod_AAR.Text = "Вывод данных";
            // 
            // chartsin_AAR
            // 
            chartArea1.Name = "ChartArea1";
            chartsin_AAR.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartsin_AAR.Legends.Add(legend1);
            chartsin_AAR.Location = new Point(162, 28);
            chartsin_AAR.Name = "chartsin_AAR";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartsin_AAR.Series.Add(series1);
            chartsin_AAR.Size = new Size(438, 375);
            chartsin_AAR.TabIndex = 5;
            chartsin_AAR.Text = "chart1";
            // 
            // dataGridView_AAR
            // 
            dataGridView_AAR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_AAR.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView_AAR.Location = new Point(14, 51);
            dataGridView_AAR.Name = "dataGridView_AAR";
            dataGridView_AAR.RowHeadersVisible = false;
            dataGridView_AAR.RowHeadersWidth = 51;
            dataGridView_AAR.Size = new Size(105, 352);
            dataGridView_AAR.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "X";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "F(X)";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 50;
            // 
            // labelres_AAR
            // 
            labelres_AAR.AutoSize = true;
            labelres_AAR.Location = new Point(14, 28);
            labelres_AAR.Name = "labelres_AAR";
            labelres_AAR.Size = new Size(75, 20);
            labelres_AAR.TabIndex = 0;
            labelres_AAR.Text = "Результат";
            // 
            // groupBoxVvod_AAR
            // 
            groupBoxVvod_AAR.Controls.Add(textBoxStop_AAR);
            groupBoxVvod_AAR.Controls.Add(textBoxStart_AAR);
            groupBoxVvod_AAR.Controls.Add(labelStop_AAR);
            groupBoxVvod_AAR.Controls.Add(labelStart_AAR);
            groupBoxVvod_AAR.Location = new Point(12, 308);
            groupBoxVvod_AAR.Name = "groupBoxVvod_AAR";
            groupBoxVvod_AAR.Size = new Size(286, 125);
            groupBoxVvod_AAR.TabIndex = 2;
            groupBoxVvod_AAR.TabStop = false;
            groupBoxVvod_AAR.Text = "Ввод данных";
            // 
            // textBoxStop_AAR
            // 
            textBoxStop_AAR.Location = new Point(165, 69);
            textBoxStop_AAR.Name = "textBoxStop_AAR";
            textBoxStop_AAR.Size = new Size(82, 27);
            textBoxStop_AAR.TabIndex = 3;
            // 
            // textBoxStart_AAR
            // 
            textBoxStart_AAR.Location = new Point(21, 69);
            textBoxStart_AAR.Name = "textBoxStart_AAR";
            textBoxStart_AAR.Size = new Size(85, 27);
            textBoxStart_AAR.TabIndex = 3;
            // 
            // labelStop_AAR
            // 
            labelStop_AAR.AutoSize = true;
            labelStop_AAR.Location = new Point(156, 35);
            labelStop_AAR.Name = "labelStop_AAR";
            labelStop_AAR.Size = new Size(91, 20);
            labelStop_AAR.TabIndex = 3;
            labelStop_AAR.Text = "Конец шага";
            // 
            // labelStart_AAR
            // 
            labelStart_AAR.AutoSize = true;
            labelStart_AAR.Location = new Point(21, 35);
            labelStart_AAR.Name = "labelStart_AAR";
            labelStart_AAR.Size = new Size(85, 20);
            labelStart_AAR.TabIndex = 3;
            labelStart_AAR.Text = "Старт шага";
            // 
            // buttonDone_AAR
            // 
            buttonDone_AAR.BackColor = SystemColors.GrayText;
            buttonDone_AAR.Location = new Point(444, 351);
            buttonDone_AAR.Name = "buttonDone_AAR";
            buttonDone_AAR.Size = new Size(138, 79);
            buttonDone_AAR.TabIndex = 3;
            buttonDone_AAR.Text = "Выполнить";
            buttonDone_AAR.UseVisualStyleBackColor = false;
            buttonDone_AAR.Click += buttonDone_AAR_Click;
            // 
            // buttonVopros_AAR
            // 
            buttonVopros_AAR.BackColor = SystemColors.ActiveCaption;
            buttonVopros_AAR.Location = new Point(332, 351);
            buttonVopros_AAR.Name = "buttonVopros_AAR";
            buttonVopros_AAR.Size = new Size(94, 79);
            buttonVopros_AAR.TabIndex = 4;
            buttonVopros_AAR.Text = "Справка";
            buttonVopros_AAR.UseVisualStyleBackColor = false;
            buttonVopros_AAR.Click += buttonVopros_AAR_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 450);
            Controls.Add(buttonVopros_AAR);
            Controls.Add(buttonDone_AAR);
            Controls.Add(groupBoxVvod_AAR);
            Controls.Add(groupBoxVivod_AAR);
            Controls.Add(groupBoxUsl_AAR);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6|Таск 2|Вариант 12|Ашарабзянова А.Р.";
            groupBoxUsl_AAR.ResumeLayout(false);
            groupBoxUsl_AAR.PerformLayout();
            groupBoxVivod_AAR.ResumeLayout(false);
            groupBoxVivod_AAR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartsin_AAR).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_AAR).EndInit();
            groupBoxVvod_AAR.ResumeLayout(false);
            groupBoxVvod_AAR.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUsl_AAR;
        private Label labelU_AAR;
        private Label labelUsl_AAR;
        private GroupBox groupBoxVivod_AAR;
        private GroupBox groupBoxVvod_AAR;
        private TextBox textBoxStop_AAR;
        private TextBox textBoxStart_AAR;
        private Label labelStop_AAR;
        private Label labelStart_AAR;
        private Button buttonDone_AAR;
        private Button buttonVopros_AAR;
        private Label labelres_AAR;
        private DataGridView dataGridView_AAR;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartsin_AAR;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
