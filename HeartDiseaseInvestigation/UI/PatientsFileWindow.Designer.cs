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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataFilterControl1 = new HeartDiseaseInvestigation.UI.DataFilterControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.graphsControl1 = new HeartDiseaseInvestigation.UI.GraphsControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonResetZoom = new System.Windows.Forms.Button();
            this.zoomOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxTree = new System.Windows.Forms.PictureBox();
            this.zoomIn = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTree)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1134, 687);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataFilterControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1126, 658);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataFilterControl1
            // 
            this.dataFilterControl1.Location = new System.Drawing.Point(1, 0);
            this.dataFilterControl1.Name = "dataFilterControl1";
            this.dataFilterControl1.Size = new System.Drawing.Size(1119, 649);
            this.dataFilterControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.graphsControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1126, 658);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Graphs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // graphsControl1
            // 
            this.graphsControl1.Location = new System.Drawing.Point(22, 38);
            this.graphsControl1.Name = "graphsControl1";
            this.graphsControl1.Size = new System.Drawing.Size(1123, 655);
            this.graphsControl1.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonResetZoom);
            this.tabPage3.Controls.Add(this.zoomOut);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.zoomIn);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1126, 658);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Decision Tree Auto";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonResetZoom
            // 
            this.buttonResetZoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetZoom.Location = new System.Drawing.Point(125, 3);
            this.buttonResetZoom.Name = "buttonResetZoom";
            this.buttonResetZoom.Size = new System.Drawing.Size(145, 49);
            this.buttonResetZoom.TabIndex = 3;
            this.buttonResetZoom.Text = "Reset Zoom";
            this.buttonResetZoom.UseVisualStyleBackColor = true;
            this.buttonResetZoom.Click += new System.EventHandler(this.buttonResetZoom_Click);
            // 
            // zoomOut
            // 
            this.zoomOut.Location = new System.Drawing.Point(67, 3);
            this.zoomOut.Name = "zoomOut";
            this.zoomOut.Size = new System.Drawing.Size(52, 49);
            this.zoomOut.TabIndex = 2;
            this.zoomOut.UseVisualStyleBackColor = true;
            this.zoomOut.Click += new System.EventHandler(this.zoomOut_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBoxTree);
            this.panel1.Location = new System.Drawing.Point(3, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 597);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxTree
            // 
            this.pictureBoxTree.Location = new System.Drawing.Point(4, 3);
            this.pictureBoxTree.Name = "pictureBoxTree";
            this.pictureBoxTree.Size = new System.Drawing.Size(1116, 594);
            this.pictureBoxTree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTree.TabIndex = 0;
            this.pictureBoxTree.TabStop = false;
            // 
            // zoomIn
            // 
            this.zoomIn.Location = new System.Drawing.Point(7, 3);
            this.zoomIn.Name = "zoomIn";
            this.zoomIn.Size = new System.Drawing.Size(54, 49);
            this.zoomIn.TabIndex = 1;
            this.zoomIn.UseVisualStyleBackColor = true;
            this.zoomIn.Click += new System.EventHandler(this.zoomIn_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1126, 658);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Decision Tree Manual";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1126, 658);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Add Patient";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // PatientsFileWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 704);
            this.Controls.Add(this.tabControl1);
            this.Name = "PatientsFileWindow";
            this.Text = "Heart Disease Classifier";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UI.DataFilterControl dataFilterControl1;
        private UI.GraphsControl graphsControl1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxTree;
        private System.Windows.Forms.Button zoomIn;
        private System.Windows.Forms.Button zoomOut;
        private System.Windows.Forms.Button buttonResetZoom;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
    }
}

