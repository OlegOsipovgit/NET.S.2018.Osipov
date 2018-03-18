using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitInsert
{
    
        public class InsertNumber
        {
     
        public static int Insert(int numberSource, int numberIn, int i, int j)
        {
            numberIn = numberIn << i;
            int a = int.MaxValue << i;
            int b = a | numberSource;
            int c = numberIn & b;
            return c;
  
            }
        }
    
}

