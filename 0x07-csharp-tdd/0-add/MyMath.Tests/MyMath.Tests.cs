using NUnit.Framework;

namespace MyMath.Tests
{
    ///<summary> Tests for Operations Class </summary>
    [TestFixture]
    public class Operations_Tests
    {
        /// <sumary> Test for Add method from MyMath Class </sumary>
        [Test]
        [TestCase(0, 4)]
        [TestCase(0, 0)]
        [TestCase(5, 10)]
        [TestCase(-4, -10)]
        [TestCase(-5, 8)]
        [TestCase(1000, 2)]
        [TestCase(1, -1)]
        [TestCase(-0, -0)]
        public void Add_whenTwoNumbersPassed_ReturnsSumResult(int a, int b)
        {
            int result = Operations.Add(a, b);
            Assert.AreEqual(a + b, result);
        }
    }
}