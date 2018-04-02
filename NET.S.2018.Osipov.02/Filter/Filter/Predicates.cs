using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter
{
    public class IsContainNumber : IPredicate
    {
        public int specifiednumber;

        public IsContainNumber(int specifiednumber)
        {
            this.specifiednumber = specifiednumber;
        }

        public bool IsMatch(int number)
        {
            while (number != 0)
            {
                if (number % 10 == specifiednumber) 
                {
                    return true;
                }
                number = number / 10;
            }
            return false;
        }
    } 
}