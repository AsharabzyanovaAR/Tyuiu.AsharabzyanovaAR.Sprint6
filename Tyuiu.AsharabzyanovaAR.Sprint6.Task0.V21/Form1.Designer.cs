namespace Tyuiu.AsharabzyanovaAR.Sprint6.Task0.V21
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
            groupBoxUsl_AAR = new GroupBox();
            pictureBoxFormula_AAR = new PictureBox();
            labelUslovie_AAR = new Label();
            labelText_AAR = new Label();
            groupBoxVV_AAR = new GroupBox();
            textBoxVarX_AAR = new TextBox();
            labelX_AAR = new Label();
            groupBoxD_AAR = new GroupBox();
            textBoxResult_AAR = new TextBox();
            labelres_AAR = new Label();
            buttonDone_AAR = new Button();
            button2 = new Button();
            groupBoxUsl_AAR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_AAR).BeginInit();
            groupBoxVV_AAR.SuspendLayout();
            groupBoxD_AAR.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxUsl_AAR
            // 
            groupBoxUsl_AAR.Controls.Add(pictureBoxFormula_AAR);
            groupBoxUsl_AAR.Controls.Add(labelUslovie_AAR);
            groupBoxUsl_AAR.Controls.Add(labelText_AAR);
            groupBoxUsl_AAR.Location = new Point(12, 12);
            groupBoxUsl_AAR.Name = "groupBoxUsl_AAR";
            groupBoxUsl_AAR.Size = new Size(759, 257);
            groupBoxUsl_AAR.TabIndex = 0;
            groupBoxUsl_AAR.TabStop = false;
            groupBoxUsl_AAR.Enter += groupBox1_Enter;
            // 
            // pictureBoxFormula_AAR
            // 
            pictureBoxFormula_AAR.Image = (Image)resources.GetObject("pictureBoxFormula_AAR.Image");
            pictureBoxFormula_AAR.Location = new Point(353, 26);
            pictureBoxFormula_AAR.Name = "pictureBoxFormula_AAR";
            pictureBoxFormula_AAR.Size = new Size(400, 62);
            pictureBoxFormula_AAR.TabIndex = 2;
            pictureBoxFormula_AAR.TabStop = false;
            // 
            // labelUslovie_AAR
            // 
            labelUslovie_AAR.AutoSize = true;
            labelUslovie_AAR.Location = new Point(6, 54);
            labelUslovie_AAR.Name = "labelUslovie_AAR";
            labelUslovie_AAR.Size = new Size(257, 20);
            labelUslovie_AAR.TabIndex = 1;
            labelUslovie_AAR.Text = "Вычислить выражение по формуле";
            // 
            // labelText_AAR
            // 
            labelText_AAR.AutoSize = true;
            labelText_AAR.Location = new Point(6, 23);
            labelText_AAR.Name = "labelText_AAR";
            labelText_AAR.Size = new Size(67, 20);
            labelText_AAR.TabIndex = 0;
            labelText_AAR.Text = "Условие";
            // 
            // groupBoxVV_AAR
            // 
            groupBoxVV_AAR.Controls.Add(textBoxVarX_AAR);
            groupBoxVV_AAR.Controls.Add(labelX_AAR);
            groupBoxVV_AAR.Location = new Point(12, 287);
            groupBoxVV_AAR.Name = "groupBoxVV_AAR";
            groupBoxVV_AAR.Size = new Size(321, 111);
            groupBoxVV_AAR.TabIndex = 1;
            groupBoxVV_AAR.TabStop = false;
            groupBoxVV_AAR.Text = "Ввод данных";
            // 
            // textBoxVarX_AAR
            // 
            textBoxVarX_AAR.Location = new Point(6, 66);
            textBoxVarX_AAR.Name = "textBoxVarX_AAR";
            textBoxVarX_AAR.Size = new Size(125, 27);
            textBoxVarX_AAR.TabIndex = 2;
            textBoxVarX_AAR.KeyPress += textBoxVarX_AAR_KeyPress;
            // 
            // labelX_AAR
            // 
            labelX_AAR.AutoSize = true;
            labelX_AAR.Location = new Point(6, 34);
            labelX_AAR.Name = "labelX_AAR";
            labelX_AAR.Size = new Size(111, 20);
            labelX_AAR.TabIndex = 2;
            labelX_AAR.Text = "Переменная X";
            // 
            // groupBoxD_AAR
            // 
            groupBoxD_AAR.Controls.Add(textBoxResult_AAR);
            groupBoxD_AAR.Controls.Add(labelres_AAR);
            groupBoxD_AAR.Location = new Point(405, 287);
            groupBoxD_AAR.Name = "groupBoxD_AAR";
            groupBoxD_AAR.Size = new Size(293, 111);
            groupBoxD_AAR.TabIndex = 2;
            groupBoxD_AAR.TabStop = false;
            groupBoxD_AAR.Text = "Вывод данных";
            // 
            // textBoxResult_AAR
            // 
            textBoxResult_AAR.Location = new Point(6, 66);
            textBoxResult_AAR.Name = "textBoxResult_AAR";
            textBoxResult_AAR.ReadOnly = true;
            textBoxResult_AAR.Size = new Size(125, 27);
            textBoxResult_AAR.TabIndex = 1;
            // 
            // labelres_AAR
            // 
            labelres_AAR.AutoSize = true;
            labelres_AAR.Location = new Point(6, 34);
            labelres_AAR.Name = "labelres_AAR";
            labelres_AAR.Size = new Size(75, 20);
            labelres_AAR.TabIndex = 0;
            labelres_AAR.Text = "Результат";
            // 
            // buttonDone_AAR
            // 
            buttonDone_AAR.Location = new Point(588, 409);
            buttonDone_AAR.Name = "buttonDone_AAR";
            buttonDone_AAR.Size = new Size(110, 29);
            buttonDone_AAR.TabIndex = 3;
            buttonDone_AAR.Text = "Выполнить";
            buttonDone_AAR.UseVisualStyleBackColor = true;
            buttonDone_AAR.Click += buttonDone_Click;
            // 
            // button2
            // 
            button2.Location = new Point(523, 409);
            button2.Name = "button2";
            button2.Size = new Size(59, 29);
            button2.TabIndex = 4;
            button2.Text = "?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(buttonDone_AAR);
            Controls.Add(groupBoxD_AAR);
            Controls.Add(groupBoxVV_AAR);
            Controls.Add(groupBoxUsl_AAR);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6|Таск 0|Вариант 21|Ашарабзянова А.Р.";
            groupBoxUsl_AAR.ResumeLayout(false);
            groupBoxUsl_AAR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_AAR).EndInit();
            groupBoxVV_AAR.ResumeLayout(false);
            groupBoxVV_AAR.PerformLayout();
            groupBoxD_AAR.ResumeLayout(false);
            groupBoxD_AAR.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUsl_AAR;
        private PictureBox pictureBoxFormula_AAR;
        private Label labelUslovie_AAR;
        private Label labelText_AAR;
        private GroupBox groupBoxVV_AAR;
        private TextBox textBoxVarX_AAR;
        private Label labelX_AAR;
        private GroupBox groupBoxD_AAR;
        private TextBox textBoxResult_AAR;
        private Label labelres_AAR;
        private Button buttonDone_AAR;
        private Button button2;
    }
}
