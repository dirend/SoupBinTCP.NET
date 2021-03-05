//using System;
using Xunit;
using SoupBinTCP.NET.Messages;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestMethod1()
        {
            var message = new Debug("Hi");
            message.TotalBytes.ToString();
            Assert.Equal(3, message.Length);
        }

        [Fact]
        public void TestMethod2()
        {
            var message = new Debug("HiHiHiHiHiHiHiHiHiHiHiHiHiHi");
            Assert.Equal(29, message.Length);
        }
    }
}
