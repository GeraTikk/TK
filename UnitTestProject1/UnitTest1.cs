using TK2VAR;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SucseesTestMethod1()
        {
            var win = new MainWindow();
            Assert.IsTrue(win.Test("19", "37", "20"));
        }
    }
}
