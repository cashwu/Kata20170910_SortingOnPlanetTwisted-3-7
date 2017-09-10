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
        public void input_3_4_should_return_4_3()
        {
            SortTwisted37ShouldBe(new[] { 4, 3 }, new[] { 3, 4 });
        }

        [TestMethod]
        public void input_3_8_should_return_3_8()
        {
            SortTwisted37ShouldBe(new[] { 3, 8 }, new[] { 3, 8 });
        }

        [TestMethod]
        public void input_7_8_should_return_7_8()
        {
            SortTwisted37ShouldBe(new[] { 7, 8 }, new[] { 7, 8 });
        }

        [TestMethod]
        public void input_7_6_should_return_7_6()
        {
            SortTwisted37ShouldBe(new[] { 7, 6 }, new[] { 7, 6 });
        }

        [TestMethod]
        public void input_7_2_should_return_2_7()
        {
            SortTwisted37ShouldBe(new[] { 2, 7 }, new[] { 7, 2 });
        }

        [TestMethod]
        public void input_3_7_should_return_7_3()
        {
            SortTwisted37ShouldBe(new[] { 7, 3 }, new[] { 3, 7 });
        }

        [TestMethod]
        public void input_2_3_4_should_return_2_4_3()
        {
            SortTwisted37ShouldBe(new[] { 2, 4, 3 }, new[] { 2, 3, 4 });
        }

        [TestMethod]
        public void input_6_7_8_should_return_7_8_6()
        {
            SortTwisted37ShouldBe(new[] { 7, 6, 8 }, new[] { 6, 7, 8 });
        }

        [TestMethod]
        public void input_1_to_9_should_return_1_2_7_4_5_6_3_8_9()
        {
            SortTwisted37ShouldBe(new[] { 1, 2, 7, 4, 5, 6, 3, 8, 9 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
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
            return array.Select(Replace3to7_and_7to3)
                        .OrderBy(a => a)
                        .Select(Replace3to7_and_7to3)
                        .ToArray();
        }

        private static int Replace3to7_and_7to3(int num)
        {
            return num == 3 ? 7 : (num == 7 ? 3 : num);
        }
    }
}
