namespace HeartDiseaseInvestigation.UI
{
    partial class DataFilterControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxHeartData = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addfilterButton = new System.Windows.Forms.Button();
            this.buttonResetFilters = new System.Windows.Forms.Button();
            this.filter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.filtersLabel = new System.Windows.Forms.Label();
            this.heartDataTable = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.heartDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxHeartData
            // 
            this.comboBoxHeartData.FormattingEnabled = true;
            this.comboBoxHeartData.Location = new System.Drawing.Point(66, 8);
            this.comboBoxHeartData.Name = "comboBoxHeartData";
            this.comboBoxHeartData.Size = new System.Drawing.Size(246, 24);
            this.comboBoxHeartData.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(196, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 22);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "-";
            // 
            // addfilterButton
            // 
            this.addfilterButton.Location = new System.Drawing.Point(318, 8);
            this.addfilterButton.Name = "addfilterButton";
            this.addfilterButton.Size = new System.Drawing.Size(98, 23);
            this.addfilterButton.TabIndex = 4;
            this.addfilterButton.Text = "Add Filter";
            this.addfilterButton.UseVisualStyleBackColor = true;
            this.addfilterButton.Click += new System.EventHandler(this.addfilterButton_Click);
            // 
            // buttonResetFilters
            // 
            this.buttonResetFilters.Location = new System.Drawing.Point(318, 38);
            this.buttonResetFilters.Name = "buttonResetFilters";
            this.buttonResetFilters.Size = new System.Drawing.Size(98, 23);
            this.buttonResetFilters.TabIndex = 5;
            this.buttonResetFilters.Text = "Reset filters";
            this.buttonResetFilters.UseVisualStyleBackColor = true;
            this.buttonResetFilters.Click += new System.EventHandler(this.buttonResetFilters_Click);
            // 
            // filter
            // 
            this.filter.Location = new System.Drawing.Point(318, 66);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(98, 23);
            this.filter.TabIndex = 6;
            this.filter.Text = "Filter data";
            this.filter.UseVisualStyleBackColor = true;
            this.filter.Click += new System.EventHandler(this.filter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 51);
            this.label2.TabIndex = 7;
            this.label2.Text = "Leave this space \r\nin blank for a \r\nsingle search";
            // 
            // filtersLabel
            // 
            this.filtersLabel.AutoSize = true;
            this.filtersLabel.Location = new System.Drawing.Point(422, 11);
            this.filtersLabel.Name = "filtersLabel";
            this.filtersLabel.Size = new System.Drawing.Size(50, 17);
            this.filtersLabel.TabIndex = 9;
            this.filtersLabel.Text = "Filters:";
            // 
            // heartDataTable
            // 
            this.heartDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.heartDataTable.Location = new System.Drawing.Point(17, 135);
            this.heartDataTable.Name = "heartDataTable";
            this.heartDataTable.RowHeadersWidth = 51;
            this.heartDataTable.RowTemplate.Height = 24;
            this.heartDataTable.Size = new System.Drawing.Size(1484, 766);
            this.heartDataTable.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(853, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(524, 51);
            this.label3.TabIndex = 11;
            this.label3.Text = "El Marcapasos De Marta";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(608, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(769, 10);
            this.label4.TabIndex = 12;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(561, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(779, 10);
            this.label5.TabIndex = 13;
            this.label5.Text = "label5";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::HeartDiseaseInvestigation.Properties.Resources.logo;
            this.pictureBox1.InitialImage = global::HeartDiseaseInvestigation.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(1383, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // DataFilterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.heartDataTable);
            this.Controls.Add(this.filtersLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.buttonResetFilters);
            this.Controls.Add(this.addfilterButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBoxHeartData);
            this.Name = "DataFilterControl";
            this.Size = new System.Drawing.Size(1504, 924);
            ((System.ComponentModel.ISupportInitialize)(this.heartDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxHeartData;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addfilterButton;
        private System.Windows.Forms.Button buttonResetFilters;
        private System.Windows.Forms.Button filter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label filtersLabel;
        private System.Windows.Forms.DataGridView heartDataTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
