using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrafficFlow;

namespace UnitTest
{
    [TestClass]
    public class TrafficUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var light = new Light
            {
                SwitchTime = 10
            };

            var actual = light.TimeToWait(5);
            var expected = 0;
            Assert.AreEqual(expected, actual, "Should be zero");
        }

        [TestMethod]
        public void TestMethod2()
        {
            var light = new Light
            {
                SwitchTime = 10
            };

            var actual = light.TimeToWait(15);
            var expected = 5;
            Assert.AreEqual(expected, actual, "Should be 5");
        }
    }
}
