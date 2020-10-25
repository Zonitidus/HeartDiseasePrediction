using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HeartDiseaseInvestigation.DecisionTreeClassifier;
using HeartDiseaseInvestigation.Model;
using HeartDiseaseInvestigation;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DecisionTreeTest
{
    [TestClass]
    public class UnitTest1
    {
        private System.Windows.Forms.ComboBox comboBoxHeartData;
        
        [TestMethod]
        public void TestMethod1()
        {
            comboBoxHeartData = new System.Windows.Forms.ComboBox();
            this.comboBoxHeartData.FormattingEnabled = true;
            //this.comboBoxHeartData.Location = new System.Drawing.Point(3, 3);
            this.comboBoxHeartData.Name = "comboBoxHeartData";
            //this.comboBoxHeartData.Size = new System.Drawing.Size(246, 24);
            this.comboBoxHeartData.TabIndex = 0;
            DataManager dta = new DataManager();
            dta.LoadCSV(comboBoxHeartData);
            
        }
    }
}
