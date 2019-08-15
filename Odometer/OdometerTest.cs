using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Odometer
{
    [TestClass]
    public class OdometerTest
    {
        [TestMethod]
        public void TestOdometerExampleCases()
        {
            int[] arr1 = { 4, 3, 9, 5 };
            int[] expected1 = { 4, 3, 9, 6 };
            Odometer.Count(arr1, 1);
            int[] arr2 = { 4, 3, 4, 9 };
            int[] expected2 = { 4, 3, 5, 0 };
            Odometer.Count(arr2, 1);
            int[] arr3 = { 9, 9, 9, 9 };
            int[] expected3 = { 1, 0, 0, 0 };
            Odometer.Count(arr3, 1);
            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual(expected1[i], arr1[i]);
                Assert.AreEqual(expected2[i], arr2[i]);
                Assert.AreEqual(expected3[i], arr3[i]);
            }
        }

        [TestMethod]
        public void TestOdometerDecrement()
        {
            int[] arr = { 7, 6, 5, 0 };
            int[] expected = { 7, 6, 4, 9 };
            Odometer.Count(arr, -1);

            for (int i = 0; i < arr.Length; i++)
            {
                Assert.AreEqual(expected[i], arr[i]);
            }
        }

        [TestMethod]
        public void TestOdometerDecrementUnderflow()
        {
            int[] arr = { 0, 0, 0, 0 };
            int[] expected = { 9, 9, 9, 9 };
            Odometer.Count(arr, -1);

            for (int i = 0; i < arr.Length; i++)
            {
                Assert.AreEqual(expected[i], arr[i]);
            }
        }

        [TestMethod]

        public void TestOdometerWithEmptyArrayIsNoOp()
        {
            int[] arr = { };
            Odometer.Count(arr, 1);

            Assert.AreEqual(0, arr.Length);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestOdometerBadArgument()
        {
            int[] arr = { 1, 3, 10, 0 };
            Odometer.Count(arr, 1);
        }
    }
}
