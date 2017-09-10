﻿using System;
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
            SortTwisted37ShouldBe(new[] { 3, 7 }, new[] { 7, 3 });
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
            if (array[0] == 3 && array[1] > 3 && array[1] <= 7)
            {
                return new[] { array[1], array[0] };
            }
            else if(array[0] == 7 && array[1] <= 3)
            {
                return new[] { array[1], array[0] };
            }

            return array;
        }
    }
}
