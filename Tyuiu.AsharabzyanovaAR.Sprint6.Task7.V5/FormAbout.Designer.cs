namespace Tyuiu.AsharabzyanovaAR.Sprint6.Task7.V5
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxAlina_AAR = new PictureBox();
            label1 = new Label();
            buttonOK_AAR = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAlina_AAR).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAlina_AAR
            // 
            pictureBoxAlina_AAR.Image = (Image)resources.GetObject("pictureBoxAlina_AAR.Image");
            pictureBoxAlina_AAR.Location = new Point(12, 23);
            pictureBoxAlina_AAR.Name = "pictureBoxAlina_AAR";
            pictureBoxAlina_AAR.Size = new Size(202, 151);
            pictureBoxAlina_AAR.TabIndex = 0;
            pictureBoxAlina_AAR.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(231, 34);
            label1.Name = "label1";
            label1.Size = new Size(402, 140);
            label1.TabIndex = 1;
            label1.Text = resources.GetString("label1.Text");
            // 
            // buttonOK_AAR
            // 
            buttonOK_AAR.Location = new Point(539, 182);
            buttonOK_AAR.Name = "buttonOK_AAR";
            buttonOK_AAR.Size = new Size(94, 29);
            buttonOK_AAR.TabIndex = 2;
            buttonOK_AAR.Text = "OK";
            buttonOK_AAR.UseVisualStyleBackColor = true;
            buttonOK_AAR.Click += buttonOK_AAR_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 223);
            Controls.Add(buttonOK_AAR);
            Controls.Add(label1);
            Controls.Add(pictureBoxAlina_AAR);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О разработчике";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAlina_AAR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAlina_AAR;
        private Label label1;
        private Button buttonOK_AAR;
    }
}