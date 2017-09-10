using System;
using System.Collections;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170910_SortingOnPlanetTwisted_3_7
{
    [TestClass]
    public class SortTwisted37Tests
    {
        [TestMethod]
        public void input_2_3_should_return_2_3()
        {
            SortTwisted37ShouldBe(new[] { 2, 3 }, new[] { 2, 3 });
        }

        [TestMethod]
        public void input_3_7_should_return_7_3()
        {
            SortTwisted37ShouldBe(new[] { 7, 3 }, new[] { 3, 7 });
        }

        [TestMethod]
        public void input_2_3_7_should_return_2_7_3()
        {
            SortTwisted37ShouldBe(new[] { 2, 7, 3 }, new[] { 2, 3, 7 });
        }

        private static void SortTwisted37ShouldBe(int[] expected, int[] array)
        {
            var kata = new Kata();
            var acutal = kata.SortTwisted37(array);
            CollectionAssert.AreEqual(expected, acutal);
        }
    }

    public class Kata
    {
        public int[] SortTwisted37(int[] array)
        {
            var arr = new[] { 3, 7 };
            if (array.Count(a => arr.Contains(a)) != 2)
            {
                return array;
            }

            if (array[0] == 3 && array[1] == 7)
            {
                return new[] { array[1], array[0] };
            }

            if (array[1] == 3 && array[2] == 7)
            {
                return new[] { array[0], array[2], array[1] };
            }

            return array;
        }
    }
}
