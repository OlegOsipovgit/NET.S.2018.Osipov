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
            ///<summary>
            ///logic of Insert Method
            /// </summary>
            int numberInLeft = numberIn >> j+2;
            numberInLeft= numberInLeft << j+2;
            int numberInRight = numberIn << 30 - i;
            numberInRight=numberInRight >> 30 - i;
            int number = numberInLeft | numberInRight;

            numberSource = numberSource << i;
            int numberResult = number | numberSource;
            
            return numberResult;
  
            }
        }
    
}

