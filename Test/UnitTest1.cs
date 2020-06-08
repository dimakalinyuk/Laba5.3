using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double[] b = {29, 28, 81, 74, 71};
            int result = (int)DimaOOP5.Marsh.Number();
            Assert.AreEqual(283, result);

        }
    }
}
