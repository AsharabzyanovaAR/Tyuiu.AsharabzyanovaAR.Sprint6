namespace Tyuiu.AsharabzyanovaAR.Sprint6.Task3.V28
{
    partial class FormSprint6_AAR
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
            groupBoxUsl_AAR = new GroupBox();
            dataGridViewmTRX_AAR = new DataGridView();
            labelmatrica_AAR = new Label();
            groupBoxVivod_AAR = new GroupBox();
            dataGridViewRES_AAR = new DataGridView();
            labelresul_AAR = new Label();
            buttonDone_AAR = new Button();
            buttonInfa_AAR = new Button();
            groupBoxUsl_AAR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewmTRX_AAR).BeginInit();
            groupBoxVivod_AAR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRES_AAR).BeginInit();
            SuspendLayout();
            // 
            // groupBoxUsl_AAR
            // 
            groupBoxUsl_AAR.Controls.Add(dataGridViewmTRX_AAR);
            groupBoxUsl_AAR.Controls.Add(labelmatrica_AAR);
            groupBoxUsl_AAR.Location = new Point(12, 12);
            groupBoxUsl_AAR.Name = "groupBoxUsl_AAR";
            groupBoxUsl_AAR.Size = new Size(699, 410);
            groupBoxUsl_AAR.TabIndex = 0;
            groupBoxUsl_AAR.TabStop = false;
            groupBoxUsl_AAR.Text = "Условие";
            // 
            // dataGridViewmTRX_AAR
            // 
            dataGridViewmTRX_AAR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewmTRX_AAR.Location = new Point(385, 23);
            dataGridViewmTRX_AAR.Name = "dataGridViewmTRX_AAR";
            dataGridViewmTRX_AAR.RowHeadersVisible = false;
            dataGridViewmTRX_AAR.RowHeadersWidth = 51;
            dataGridViewmTRX_AAR.Size = new Size(300, 358);
            dataGridViewmTRX_AAR.TabIndex = 1;
            // 
            // labelmatrica_AAR
            // 
            labelmatrica_AAR.AutoSize = true;
            labelmatrica_AAR.Location = new Point(6, 23);
            labelmatrica_AAR.Name = "labelmatrica_AAR";
            labelmatrica_AAR.Size = new Size(373, 240);
            labelmatrica_AAR.TabIndex = 0;
            labelmatrica_AAR.Text = "Дана матрица 5 на 5\r\n-9   8   9  16 -18\r\n\r\n -13 -11 -20 -15   9\r\n\r\n  18  13 -12 -15 -11\r\n\r\n  10  -2  19  -4 -10\r\n\r\n   6 -20  -4  13 -14\r\nЗаменить четные значения в четвертой строке на 0.\r\n\r\n";
            // 
            // groupBoxVivod_AAR
            // 
            groupBoxVivod_AAR.Controls.Add(dataGridViewRES_AAR);
            groupBoxVivod_AAR.Controls.Add(labelresul_AAR);
            groupBoxVivod_AAR.Location = new Point(717, 12);
            groupBoxVivod_AAR.Name = "groupBoxVivod_AAR";
            groupBoxVivod_AAR.Size = new Size(300, 338);
            groupBoxVivod_AAR.TabIndex = 1;
            groupBoxVivod_AAR.TabStop = false;
            groupBoxVivod_AAR.Text = "Вывод данных";
            // 
            // dataGridViewRES_AAR
            // 
            dataGridViewRES_AAR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRES_AAR.Location = new Point(6, 46);
            dataGridViewRES_AAR.Name = "dataGridViewRES_AAR";
            dataGridViewRES_AAR.RowHeadersVisible = false;
            dataGridViewRES_AAR.RowHeadersWidth = 51;
            dataGridViewRES_AAR.Size = new Size(272, 286);
            dataGridViewRES_AAR.TabIndex = 1;
            // 
            // labelresul_AAR
            // 
            labelresul_AAR.AutoSize = true;
            labelresul_AAR.Location = new Point(6, 23);
            labelresul_AAR.Name = "labelresul_AAR";
            labelresul_AAR.Size = new Size(75, 20);
            labelresul_AAR.TabIndex = 0;
            labelresul_AAR.Text = "Результат";
            // 
            // buttonDone_AAR
            // 
            buttonDone_AAR.Location = new Point(854, 372);
            buttonDone_AAR.Name = "buttonDone_AAR";
            buttonDone_AAR.Size = new Size(102, 50);
            buttonDone_AAR.TabIndex = 2;
            buttonDone_AAR.Text = "Выполнить";
            buttonDone_AAR.UseVisualStyleBackColor = true;
            buttonDone_AAR.Click += buttonDone_AAR_Click;
            // 
            // buttonInfa_AAR
            // 
            buttonInfa_AAR.Location = new Point(763, 372);
            buttonInfa_AAR.Name = "buttonInfa_AAR";
            buttonInfa_AAR.Size = new Size(63, 50);
            buttonInfa_AAR.TabIndex = 3;
            buttonInfa_AAR.Text = "?";
            buttonInfa_AAR.UseVisualStyleBackColor = true;
            buttonInfa_AAR.Click += buttonInfa_AAR_Click;
            // 
            // FormSprint6_AAR
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 450);
            Controls.Add(buttonInfa_AAR);
            Controls.Add(buttonDone_AAR);
            Controls.Add(groupBoxVivod_AAR);
            Controls.Add(groupBoxUsl_AAR);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSprint6_AAR";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6|Таск 3|Вариант 28|Ашарабзянова А.Р.";
            Load += FormSprint6_AAR_Load;
            groupBoxUsl_AAR.ResumeLayout(false);
            groupBoxUsl_AAR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewmTRX_AAR).EndInit();
            groupBoxVivod_AAR.ResumeLayout(false);
            groupBoxVivod_AAR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRES_AAR).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUsl_AAR;
        private GroupBox groupBoxVivod_AAR;
        private Label labelresul_AAR;
        private Button buttonDone_AAR;
        private Button buttonInfa_AAR;
        private Label labelmatrica_AAR;
        private DataGridView dataGridViewmTRX_AAR;
        private DataGridView dataGridViewRES_AAR;
    }
}
