namespace Tyuiu.AsharabzyanovaAR.Sprint6.Task6.V9
{
    partial class FormAbout_AAR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_AAR));
            pictureBoxAlina_AAR = new PictureBox();
            labelIN_AAR = new Label();
            buttonOK_AAR = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAlina_AAR).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAlina_AAR
            // 
            pictureBoxAlina_AAR.Image = (Image)resources.GetObject("pictureBoxAlina_AAR.Image");
            pictureBoxAlina_AAR.Location = new Point(1, 12);
            pictureBoxAlina_AAR.Name = "pictureBoxAlina_AAR";
            pictureBoxAlina_AAR.Size = new Size(199, 151);
            pictureBoxAlina_AAR.TabIndex = 0;
            pictureBoxAlina_AAR.TabStop = false;
            // 
            // labelIN_AAR
            // 
            labelIN_AAR.AutoSize = true;
            labelIN_AAR.Location = new Point(206, 12);
            labelIN_AAR.Name = "labelIN_AAR";
            labelIN_AAR.Size = new Size(402, 160);
            labelIN_AAR.TabIndex = 1;
            labelIN_AAR.Text = resources.GetString("labelIN_AAR.Text");
            // 
            // buttonOK_AAR
            // 
            buttonOK_AAR.Location = new Point(514, 163);
            buttonOK_AAR.Name = "buttonOK_AAR";
            buttonOK_AAR.Size = new Size(94, 29);
            buttonOK_AAR.TabIndex = 2;
            buttonOK_AAR.Text = "OK";
            buttonOK_AAR.UseVisualStyleBackColor = true;
            buttonOK_AAR.Click += buttonOK_AAR_Click;
            // 
            // FormAbout_AAR
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 204);
            Controls.Add(buttonOK_AAR);
            Controls.Add(labelIN_AAR);
            Controls.Add(pictureBoxAlina_AAR);
            Name = "FormAbout_AAR";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAlina_AAR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAlina_AAR;
        private Label labelIN_AAR;
        private Button buttonOK_AAR;
    }
}