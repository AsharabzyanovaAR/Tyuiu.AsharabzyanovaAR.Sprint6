namespace Tyuiu.AsharabzyanovaAR.Sprint6.Task1.V4
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
            groupBox1 = new GroupBox();
            textBoxRes_AAR = new TextBox();
            label4 = new Label();
            groupBox2 = new GroupBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            textBoxStop_AAR = new TextBox();
            textBoxStart_AAR = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            buttonHeLP_AAR = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxRes_AAR);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(507, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(281, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Вывод данных";
            // 
            // textBoxRes_AAR
            // 
            textBoxRes_AAR.Font = new Font("Consolas", 9F);
            textBoxRes_AAR.Location = new Point(6, 55);
            textBoxRes_AAR.Multiline = true;
            textBoxRes_AAR.Name = "textBoxRes_AAR";
            textBoxRes_AAR.ReadOnly = true;
            textBoxRes_AAR.ScrollBars = ScrollBars.Vertical;
            textBoxRes_AAR.Size = new Size(269, 351);
            textBoxRes_AAR.TabIndex = 1;
            textBoxRes_AAR.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 23);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 0;
            label4.Text = "Результат";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(441, 305);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Условие";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(415, 40);
            label1.TabIndex = 0;
            label1.Text = "Протабулировать фуекцию sin(x) на заданном диапозоне.\r\nВвыести результат в виде таблицы";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxStop_AAR);
            groupBox3.Controls.Add(textBoxStart_AAR);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(12, 313);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(230, 125);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ввод данных";
            // 
            // textBoxStop_AAR
            // 
            textBoxStop_AAR.Location = new Point(115, 67);
            textBoxStop_AAR.Name = "textBoxStop_AAR";
            textBoxStop_AAR.Size = new Size(91, 27);
            textBoxStop_AAR.TabIndex = 3;
            // 
            // textBoxStart_AAR
            // 
            textBoxStart_AAR.Location = new Point(6, 67);
            textBoxStart_AAR.Name = "textBoxStart_AAR";
            textBoxStart_AAR.Size = new Size(85, 27);
            textBoxStart_AAR.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(115, 33);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 1;
            label3.Text = "Конец шага";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 33);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 0;
            label2.Text = "Старт шага";
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(380, 363);
            button1.Name = "button1";
            button1.Size = new Size(126, 75);
            button1.TabIndex = 3;
            button1.Text = "Выполнить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonHeLP_AAR
            // 
            buttonHeLP_AAR.BackColor = Color.DodgerBlue;
            buttonHeLP_AAR.Location = new Point(248, 363);
            buttonHeLP_AAR.Name = "buttonHeLP_AAR";
            buttonHeLP_AAR.Size = new Size(126, 75);
            buttonHeLP_AAR.TabIndex = 4;
            buttonHeLP_AAR.Text = "Справка";
            buttonHeLP_AAR.UseVisualStyleBackColor = false;
            buttonHeLP_AAR.Click += buttonHeLP_AAR_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHeLP_AAR);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6|Таск1|Вариант 4|Ашарабзянова А.Р.";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label3;
        private Label label2;
        private TextBox textBoxStart_AAR;
        private TextBox textBoxRes_AAR;
        private Label label4;
        private TextBox textBoxStop_AAR;
        private Button button1;
        private Button buttonHeLP_AAR;
    }
}
