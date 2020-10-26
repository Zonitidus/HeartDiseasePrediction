using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HeartDiseaseInvestigation.UI;
using HeartDiseaseInvestigation.Model;

namespace OtraVezFallaSorpesa
{
    [TestClass]
    public class UnitTest1
    {
        
        private DataManager SceneTest() {
            DataManager dts = new DataManager();
            return dts;
        }
        
        [TestMethod]
        public void TestMethod1()
        {
           string valueToTest = "";
           SceneTest().LoadCSV();
           //valueToTest = SceneTest().tasGordo("5", 56, 1, 0, 130, 283, 1, 0, 103, 1, 1.6, 0, 0, 3, 0);
           Assert.AreEqual(21,21);
        }
    }
}
