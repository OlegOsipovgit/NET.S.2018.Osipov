using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JaggedArray_BubbleSort;
namespace JaggedArrayTest
{
    [TestFixture]
    public class TestClass
    {
        int[][] jaggedArray = {
            new int[] {1,3,5,7,9},
            new int[] {0,2,4,6},
            new int[] {11,22} };
        [Test]
        public void TestMethod_Sort_by_Sum_Increase()
        {
            
            int[][]actual=JaggedArray.Sort_by_Sum_Increase(jaggedArray);
            int[][] expected =
            {
            new int[] {0,2,4,6},
            new int[] {1,3,5,7,9},
            new int[] {11,22}
            };
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestMethod_Sort_by_Sum_Decrease()
        {
            int[][] actual = JaggedArray.Sort_by_Sum_Decrease(jaggedArray);
            int[][] expected =
            {
              new int[] {11,22},
              new int[] {1,3,5,7,9},
              new int[] {0,2,4,6}         
            };
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestMethod_Sort_by_Max_Increase()
        {
            int[][] actual = JaggedArray.Sort_by_Max_Increase(jaggedArray);
            int[][] expected =
            {
                 new int[] {0,2,4,6},
                 new int[] {1,3,5,7,9},
                 new int[] {11,22}

            };
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestMethod_Sort_by_Max_Decrease()
        {
            int[][] actual = JaggedArray.Sort_by_Max_Decrease(jaggedArray);
            int[][] expected =
            {
                new int[] {11,22},
                new int[] {1,3,5,7,9},
                new int[] {0,2,4,6},
            };
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestMethod_Sort_by_Min_Increase()
        {
            int[][] actual = JaggedArray.Sort_by_Min_Increase(jaggedArray);
            int[][] expected =
            {
                new int[] {0,2,4,6},
                new int[] {1,3,5,7,9},
                new int[] {11,22}
             };
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestMethod_Sort_by_Min_Decrease()
        {
            int[][] actual = JaggedArray.Sort_by_Min_Decrease(jaggedArray);
            int[][] expected =
            {
                new int[] {11,22},
                new int[] {1,3,5,7,9},
                new int[] {0,2,4,6},
            };
            Assert.AreEqual(expected, actual);
        }
    }
}
