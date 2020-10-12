namespace HeartDiseaseInvestigation
{
    partial class PatientsFileWindow
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
            this.dataFilterControl1 = new HeartDiseaseInvestigation.UI.DataFilterControl();
            this.SuspendLayout();
            // 
            // dataFilterControl1
            // 
            this.dataFilterControl1.Location = new System.Drawing.Point(13, 13);
            this.dataFilterControl1.Name = "dataFilterControl1";
            this.dataFilterControl1.Size = new System.Drawing.Size(1168, 707);
            this.dataFilterControl1.TabIndex = 0;
            // 
            // PatientsFileWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 704);
            this.Controls.Add(this.dataFilterControl1);
            this.Name = "PatientsFileWindow";
            this.Text = "Heart Disease Classifier";
            this.ResumeLayout(false);

        }

        #endregion

        private UI.DataFilterControl dataFilterControl1;
    }
}

