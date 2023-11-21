using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UILayer;
using System.IO;
namespace TestProct
{
    [TestClass]
    public class UnitTest1
    {
        int res;
        [TestMethod]
        public void TestSquare()
        {
             res=Program.square(2);
             Assert.AreEqual(4, res);
        }
    }
}
