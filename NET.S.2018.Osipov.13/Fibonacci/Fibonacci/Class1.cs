using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci

{
    public static class Fibonacci
    {
       /// <summary>
       /// Fibonacci sequence method
       /// </summary>
       /// <param name="number"></param>
       /// <returns></returns>
        public static IEnumerable<int> FibonacciSequence(int number)
        {
            int current = 0;
            int previouse2 = 0;
            int previouse1 = 0;
            if (number <= 0)
            {
                throw new ArgumentException($"{nameof(number)} cant be less than 0");
            }

            for (int i = 0; i <= number; i++)
            {
                current = previouse1 + previouse2;
                previouse2 = previouse1;
                previouse1 = current;
                yield return current;
            
            }  
           
        }
    }
}
