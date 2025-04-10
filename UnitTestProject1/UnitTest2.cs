using TK2VAR;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void FailtureTestMethod1()
        {
            var win = new MainWindow();
            Assert.IsFalse(win.Test("", "", ""));
            Assert.IsFalse(win.Test("-3", "43", "-3"));
            Assert.IsFalse(win.Test("sdf", "3", "3"));
            Assert.IsFalse(win.Test("24", "34", "24"));
        }
    }
}
