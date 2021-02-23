using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    public class Operations_Tests
    {

        [Test]
        public void Max_whenNumsIsEmpty_returnZero()
        {
            List<int> nums = new List<int>();

            int max = Operations.Max(nums);
            Assert.AreEqual(0, max);
        }

        [Test]
        public void Max_whenNumsIsNull_returnZero()
        {
            List<int> nums = null;

            int max = Operations.Max(nums);
            Assert.AreEqual(0, max);
        }

        [Test]
        public void Max_whenNums_returnmax()
        {
            List<int> nums = new List<int>();
            nums.Add(2);
            nums.Add(4);
            nums.Add(200);
            nums.Add(-14);

            int max = Operations.Max(nums);
            Assert.AreEqual(200, max);
        }
    }
}