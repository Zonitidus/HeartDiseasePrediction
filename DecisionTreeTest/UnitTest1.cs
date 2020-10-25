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
        public void TestTree()
        {
            comboBoxHeartData = new System.Windows.Forms.ComboBox();
            this.comboBoxHeartData.FormattingEnabled = true;
            this.comboBoxHeartData.Name = "comboBoxHeartData";
            this.comboBoxHeartData.TabIndex = 0;


            DataManager dta = new DataManager();
            dta.LoadCSV(comboBoxHeartData);
            string resul = dta.tasGordo("1", 63, 1, 3, 145, 233, 1, 0, 150, 0, 2.3, 0, 0, 1, 1);
            Assert.AreEqual(2,3);
        }
        
    }
}
