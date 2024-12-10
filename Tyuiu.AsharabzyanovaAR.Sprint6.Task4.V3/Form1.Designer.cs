namespace Tyuiu.AsharabzyanovaAR.Sprint6.Task4.V3
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
            labelUsl_AAR = new Label();
            groupBoxVV_AAR = new GroupBox();
            textBoxStop_AAR = new TextBox();
            textBoxStart_AAR = new TextBox();
            labelЫStop_AAR = new Label();
            labelStart_AAR = new Label();
            buttonDone_AAR = new Button();
            buttonSoxr_AAR = new Button();
            buttonSpravka_AAR = new Button();
            groupBoxVivod_AAR = new GroupBox();
            textBoxRes_AAR = new TextBox();
            label1 = new Label();
            chartsin_AAR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxUsl_AAR.SuspendLayout();
            groupBoxVV_AAR.SuspendLayout();
            groupBoxVivod_AAR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartsin_AAR).BeginInit();
            SuspendLayout();
            // 
            // groupBoxUsl_AAR
            // 
            groupBoxUsl_AAR.Controls.Add(labelUsl_AAR);
            groupBoxUsl_AAR.Location = new Point(12, 3);
            groupBoxUsl_AAR.Name = "groupBoxUsl_AAR";
            groupBoxUsl_AAR.Size = new Size(303, 135);
            groupBoxUsl_AAR.TabIndex = 0;
            groupBoxUsl_AAR.TabStop = false;
            groupBoxUsl_AAR.Text = "Условие";
            // 
            // labelUsl_AAR
            // 
            labelUsl_AAR.AutoSize = true;
            labelUsl_AAR.Location = new Point(6, 23);
            labelUsl_AAR.Name = "labelUsl_AAR";
            labelUsl_AAR.Size = new Size(294, 100);
            labelUsl_AAR.TabIndex = 0;
            labelUsl_AAR.Text = "Протабулировать функцию sin(x) \r\nна заданном диапозоне от -5 до 5.\r\nРезультат вывести в textBook, построить \r\nграфик функции и сохранить в файл\r\nOutPutFileTask.txt по нажатию кнопки\r\n";
            // 
            // groupBoxVV_AAR
            // 
            groupBoxVV_AAR.Controls.Add(textBoxStop_AAR);
            groupBoxVV_AAR.Controls.Add(textBoxStart_AAR);
            groupBoxVV_AAR.Controls.Add(labelЫStop_AAR);
            groupBoxVV_AAR.Controls.Add(labelStart_AAR);
            groupBoxVV_AAR.Location = new Point(333, 12);
            groupBoxVV_AAR.Name = "groupBoxVV_AAR";
            groupBoxVV_AAR.Size = new Size(201, 126);
            groupBoxVV_AAR.TabIndex = 1;
            groupBoxVV_AAR.TabStop = false;
            groupBoxVV_AAR.Text = "Ввод данных";
            // 
            // textBoxStop_AAR
            // 
            textBoxStop_AAR.Location = new Point(102, 55);
            textBoxStop_AAR.Name = "textBoxStop_AAR";
            textBoxStop_AAR.Size = new Size(66, 27);
            textBoxStop_AAR.TabIndex = 3;
            // 
            // textBoxStart_AAR
            // 
            textBoxStart_AAR.Location = new Point(16, 55);
            textBoxStart_AAR.Name = "textBoxStart_AAR";
            textBoxStart_AAR.Size = new Size(66, 27);
            textBoxStart_AAR.TabIndex = 2;
            // 
            // labelЫStop_AAR
            // 
            labelЫStop_AAR.AutoSize = true;
            labelЫStop_AAR.Location = new Point(97, 32);
            labelЫStop_AAR.Name = "labelЫStop_AAR";
            labelЫStop_AAR.Size = new Size(91, 20);
            labelЫStop_AAR.TabIndex = 1;
            labelЫStop_AAR.Text = "Конец шага";
            // 
            // labelStart_AAR
            // 
            labelStart_AAR.AutoSize = true;
            labelStart_AAR.Location = new Point(6, 32);
            labelStart_AAR.Name = "labelStart_AAR";
            labelStart_AAR.Size = new Size(85, 20);
            labelStart_AAR.TabIndex = 0;
            labelStart_AAR.Text = "Старт шага";
            // 
            // buttonDone_AAR
            // 
            buttonDone_AAR.BackColor = SystemColors.ActiveCaption;
            buttonDone_AAR.Location = new Point(540, 24);
            buttonDone_AAR.Name = "buttonDone_AAR";
            buttonDone_AAR.Size = new Size(104, 112);
            buttonDone_AAR.TabIndex = 2;
            buttonDone_AAR.Text = "Выполнить";
            buttonDone_AAR.UseVisualStyleBackColor = false;
            buttonDone_AAR.Click += buttonDone_AAR_Click;
            // 
            // buttonSoxr_AAR
            // 
            buttonSoxr_AAR.BackColor = SystemColors.HotTrack;
            buttonSoxr_AAR.Location = new Point(650, 24);
            buttonSoxr_AAR.Name = "buttonSoxr_AAR";
            buttonSoxr_AAR.Size = new Size(102, 112);
            buttonSoxr_AAR.TabIndex = 3;
            buttonSoxr_AAR.Text = "Сохранить";
            buttonSoxr_AAR.UseVisualStyleBackColor = false;
            buttonSoxr_AAR.Click += buttonSoxr_AAR_Click;
            // 
            // buttonSpravka_AAR
            // 
            buttonSpravka_AAR.BackColor = SystemColors.Desktop;
            buttonSpravka_AAR.Location = new Point(853, 24);
            buttonSpravka_AAR.Name = "buttonSpravka_AAR";
            buttonSpravka_AAR.Size = new Size(94, 112);
            buttonSpravka_AAR.TabIndex = 4;
            buttonSpravka_AAR.Text = "Справка";
            buttonSpravka_AAR.UseVisualStyleBackColor = false;
            buttonSpravka_AAR.Click += buttonSpravka_AAR_Click;
            // 
            // groupBoxVivod_AAR
            // 
            groupBoxVivod_AAR.Controls.Add(textBoxRes_AAR);
            groupBoxVivod_AAR.Controls.Add(label1);
            groupBoxVivod_AAR.Location = new Point(12, 144);
            groupBoxVivod_AAR.Name = "groupBoxVivod_AAR";
            groupBoxVivod_AAR.Size = new Size(250, 412);
            groupBoxVivod_AAR.TabIndex = 5;
            groupBoxVivod_AAR.TabStop = false;
            groupBoxVivod_AAR.Text = "Вывод";
            // 
            // textBoxRes_AAR
            // 
            textBoxRes_AAR.Location = new Point(6, 31);
            textBoxRes_AAR.Multiline = true;
            textBoxRes_AAR.Name = "textBoxRes_AAR";
            textBoxRes_AAR.ScrollBars = ScrollBars.Vertical;
            textBoxRes_AAR.Size = new Size(238, 375);
            textBoxRes_AAR.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 34);
            label1.Name = "label1";
            label1.Size = new Size(9, 340);
            label1.TabIndex = 0;
            label1.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // chartsin_AAR
            // 
            chartArea1.Name = "ChartArea1";
            chartsin_AAR.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartsin_AAR.Legends.Add(legend1);
            chartsin_AAR.Location = new Point(268, 153);
            chartsin_AAR.Name = "chartsin_AAR";
            chartsin_AAR.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartsin_AAR.Series.Add(series1);
            chartsin_AAR.Size = new Size(773, 403);
            chartsin_AAR.TabIndex = 6;
            chartsin_AAR.Text = "chartsin_AAR";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 568);
            Controls.Add(chartsin_AAR);
            Controls.Add(groupBoxVivod_AAR);
            Controls.Add(buttonSpravka_AAR);
            Controls.Add(buttonSoxr_AAR);
            Controls.Add(buttonDone_AAR);
            Controls.Add(groupBoxVV_AAR);
            Controls.Add(groupBoxUsl_AAR);
            Name = "Form1";
            Text = "Спринт 6|Таск 4|Вариант 3|Ашарабзянова А.Р.";
            groupBoxUsl_AAR.ResumeLayout(false);
            groupBoxUsl_AAR.PerformLayout();
            groupBoxVV_AAR.ResumeLayout(false);
            groupBoxVV_AAR.PerformLayout();
            groupBoxVivod_AAR.ResumeLayout(false);
            groupBoxVivod_AAR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartsin_AAR).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUsl_AAR;
        private Label labelUsl_AAR;
        private GroupBox groupBoxVV_AAR;
        private TextBox textBoxStop_AAR;
        private TextBox textBoxStart_AAR;
        private Label labelЫStop_AAR;
        private Label labelStart_AAR;
        private Button buttonDone_AAR;
        private Button buttonSoxr_AAR;
        private Button buttonSpravka_AAR;
        private GroupBox groupBoxVivod_AAR;
        private Label label1;
        private TextBox textBoxRes_AAR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartsin_AAR;
    }
}
