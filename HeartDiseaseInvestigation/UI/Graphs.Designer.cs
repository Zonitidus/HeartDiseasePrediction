namespace HeartDiseaseInvestigation.UI
{
    partial class Graphs
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
            this.graphsControl1 = new HeartDiseaseInvestigation.UI.GraphsControl();
            this.SuspendLayout();
            // 
            // graphsControl1
            // 
            this.graphsControl1.Location = new System.Drawing.Point(70, 39);
            this.graphsControl1.Name = "graphsControl1";
            this.graphsControl1.Size = new System.Drawing.Size(919, 617);
            this.graphsControl1.TabIndex = 0;
            // 
            // Graphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 668);
            this.Controls.Add(this.graphsControl1);
            this.Name = "Graphs";
            this.Text = "Graphs";
            this.ResumeLayout(false);

        }

        #endregion

        private GraphsControl graphsControl1;
    }
}