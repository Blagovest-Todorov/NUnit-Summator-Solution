using NUnit.Framework;


namespace Summator.Tests
{
    public class Tests
    {
        [Test]
        public void Test_Sum_TwoPosiotiveNumbers()
        {
            long actual = Summator.Sum(new long[] { 5, 7 });
            int expected = 12;

            Assert.That(expected == actual);
        }

        [Test]
        public void Test_Sum_OnePositiveNumber()
        {
            long actual = Summator.Sum(new long[] { 5 });
            Assert.That(5 == actual);
        }

        [Test]
        public void Test_Sum_TwoNegativeNumbers()
        {
            long actual = Summator.Sum(new long[] { -7, -9 });

            Assert.That(-16 == actual);
        }

        [Test]
        public void Test_Sum_EmptyArray()
        {
            long actual = Summator.Sum(new long[] { });
           
            Assert.That(0 == actual);
        }

        [Test]
        public void Test_Sum_BigValues()
        {
            long actual = Summator.Sum(new long[] { 2000000000, 2000000000, 2000000000 });
            Assert.AreEqual(6000000000, actual);
        }

        [Test]
        public void Test_Average_TwoPosiotiveNumbers()
        {
            long expected = Summator.Average(new long[] { 5, 7 });
            int actual = 6;

            Assert.That(expected == actual);
        }
    }
}