using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PimenovaTS.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.PimenovaTS.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            int x = 4;
            int y = 10;
            int z = 16;

            int res = DataService.Calc(x, y, z);

            Assert.AreEqual(150, res);
        }
    }
}
