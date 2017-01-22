using NUnit.Framework;

namespace Power
{
    [TestFixture]

    public class PowerTest
    {
        [Test]
        public void TestPower()
        {
            IPowerCalculator powerCalculator = new Power();
            var result = powerCalculator.Calculate(2, 4);

            Assert.AreEqual(result, 16);
        }

        [Test]
        public void TestPowerZero()
        {
            IPowerCalculator powerCalculator = new Power();
            var result = powerCalculator.Calculate(121212, 0);

            Assert.AreEqual(result, 1);
        }
    }
}
