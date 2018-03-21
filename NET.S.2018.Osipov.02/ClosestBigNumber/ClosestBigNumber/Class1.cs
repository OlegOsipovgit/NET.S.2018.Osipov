using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosestBigNumber
{
    public class Searching
    {

        /// <summary>
        ///number is our assigned number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int FindNextBiggerNumber(int number)
        {
            int[] array1 = GetNum(number);
            int LengthOfNumber = array1.Length;
            Array.Sort(array1);
            int a = 0;
            for (int i = -3000000; i <= 3000000; i++)
            {
               
                int[] arr = GetNum(i);
                if (arr.Length == LengthOfNumber)
                {
                    Array.Sort(arr);
                    int sum = 0;
                    for (int j = 0; j <= arr.Length; j++)
                    {
                        if (arr[j] == array1[j]) sum += 1;
                    }
                    if (sum == arr.Length) { a=i; }
                }
            }
            return a;
        }
        public int[] GetNum(int value)
        {

            if (value % 10 == 0) return new int[] { value };

            var list = new List<int>();
            while (value != 0)
            {
                list.Add(Math.Abs(value % 10));
                value /= 10;
            }

            list.Reverse();
            return list.ToArray();
        }






    }
}



               



            


        
    



   
  


