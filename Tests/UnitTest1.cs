using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoupBinTCP.NET.Messages;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var message = new Debug("Hi");
            message.TotalBytes.ToString();
            Assert.AreEqual(3, message.Length);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var message = new Debug("HiHiHiHiHiHiHiHiHiHiHiHiHiHi");
            Assert.AreEqual(29, message.Length);
        }
    }
}
