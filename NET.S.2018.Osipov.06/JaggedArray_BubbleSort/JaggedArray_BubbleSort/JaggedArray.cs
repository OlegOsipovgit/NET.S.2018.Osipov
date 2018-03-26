using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray_BubbleSort
{
    public class JaggedArray
    {
        #region Sorting Methods
        /// <summary>
        /// Sort by increasing sums of rows
        /// </summary>
        /// <param name="arr"></param>
        public static int[][] Sort_by_Sum_Increase(int[][] arr)
        {
            for (int i = 0; i < GetFirstColumnLength(arr); i++)
                for (int j = i + 1; j < GetFirstColumnLength(arr); j++)
                    if (Sum(arr[i]) > Sum(arr[j])) Swap(ref arr[i], ref arr[j]);
            return arr;
        }
        /// <summary>
        /// Sort by decreasing sums of rows
        /// </summary>
        /// <param name="arr"></param>
        public static int[][] Sort_by_Sum_Decrease(int[][] arr)
            {
             for (int i = 0; i < GetFirstColumnLength(arr); i++)
                for (int j = i + 1; j < GetFirstColumnLength(arr); j++)
                    if (Sum(arr[i]) < Sum(arr[j])) Swap(ref arr[i], ref arr[j]);
            return arr;
        }
        /// <summary>
        /// Sort by increasing max elements of rows
        /// </summary>
        /// <param name="arr"></param>
        public static int[][] Sort_by_Max_Increase(int[][] arr)
        {
            for (int i = 0; i < GetFirstColumnLength(arr); i++)
                for (int j = i + 1; j < GetFirstColumnLength(arr); j++)
                    if (Max(arr[i]) > Max(arr[j])) Swap(ref arr[i], ref arr[j]);
            return arr;
        }
        /// <summary>
        /// Sort by decreasing max elements of rows
        /// </summary>
        /// <param name="arr"></param>
        public static int[][] Sort_by_Max_Decrease(int[][] arr)
        {
            for (int i = 0; i < GetFirstColumnLength(arr); i++)
                for (int j = i + 1; j < GetFirstColumnLength(arr); j++)
                    if (Max(arr[i]) < Max(arr[j])) Swap(ref arr[i], ref arr[j]);
            return arr;
        }
        /// <summary>
        /// Sort by increasing min elements of rows
        /// </summary>
        /// <param name="arr"></param>
        public static int[][] Sort_by_Min_Increase(int[][] arr)
        {
            for (int i = 0; i < GetFirstColumnLength(arr); i++)
                for (int j = i + 1; j < GetFirstColumnLength(arr); j++)
                    if (Min(arr[i]) > Min(arr[j])) Swap(ref arr[i], ref arr[j]);
            return arr;
        }
        /// <summary>
        /// Sort by decreasing min elements of rows
        /// </summary>
        /// <param name="arr"></param>
        public static int[][] Sort_by_Min_Decrease(int[][] arr)
        {
            for (int i = 0; i < GetFirstColumnLength(arr); i++)
                for (int j = i + 1; j < GetFirstColumnLength(arr); j++)
                    if (Min(arr[i]) < Min(arr[j])) Swap(ref arr[i], ref arr[j]);
            return arr;
        }
        #endregion
        #region Other Methods
        /// <summary>
        /// Returns the length of first column of jagged array
        /// </summary>
        /// <param name="jaggedArray"></param>
        /// <returns></returns>
        public static int GetFirstColumnLength(int[][] jaggedArray)
        {
            int count = 0;
            foreach (int[] row in jaggedArray)
            {
                count++;
            }
            return count;
        }
        /// <summary>
        /// Returns the sum of elements of the row
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int Sum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
                sum = sum + arr[i];
            return sum;
        }
        /// <summary>
        /// Swaps the references of rows
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        public static void Swap(ref int[] arr1, ref int[] arr2)
        {
            int[] temp = arr1;
            arr1 = arr2;
            arr2 = temp;
        }
        /// <summary>
        /// Returns the Max value of the row
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int Max(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
                if (max < arr[i]) max = arr[i];
            return max;
        }
        /// <summary>
        /// Returns the Min value of the row
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int Min(int[] arr)
        {
            int min =arr[0];
            for (int i = 0; i < arr.Length; i++)
                if (min > arr[i]) min = arr[i];
            return min;
        }
        #endregion
    }
}

