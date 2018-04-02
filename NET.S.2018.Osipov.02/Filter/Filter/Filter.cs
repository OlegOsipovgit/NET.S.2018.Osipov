using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter
{
    public class Filter
    {
        #region Logic
        public static int[] DigitFilter(int[] arrayofnumbers, IPredicate specifiednumber)
        {
            List<int> resultArray = new List<int>();

            if (arrayofnumbers == null)
            {
                throw new ArgumentNullException("Array reference is null");
            }

            foreach (int number in arrayofnumbers)
            {
                if (specifiednumber.IsMatch(number))
                    resultArray.Add(number);
            }
            return resultArray.ToArray();
        }
        #endregion
     }
}
