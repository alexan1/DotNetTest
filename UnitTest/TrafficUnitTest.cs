using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrafficFlow;

namespace UnitTest
{
    [TestClass]
    public class TrafficUnitTest
    {
        [TestMethod]
        public void GetTimeToWait_WithFiveMinutes_ShouldReturnZero()
        {
            var light = new Light
            {
                SwitchTime = 10
            };

            var actual = light.GetTimeToWait(5);
            var expected = 0;
            Assert.AreEqual(expected, actual, "Should be zero");
        }

        [TestMethod]
        public void GetTimeToWait_WithFifteenMinutes_ShouldReturnFive()
        {
            var light = new Light
            {
                SwitchTime = 10
            };

            var actual = light.GetTimeToWait(15);
            var expected = 5;
            Assert.AreEqual(expected, actual, "Should be 5");
        }
    }
}
