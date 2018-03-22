using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToBinary
{
    public static class Class1
    {
        /// <summary>
        /// receive decimal number and return binary number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>

        public static List <int> ConvertToBinaryExtension(this double number)
        {

            int integralofNumber = (int)Math.Floor(number);
            double fractionofNumber = number - integralofNumber;
            int temp1 = 0;
            int temp2 = 0;
            List<int> integralListofbinary = new List<int>();
            List<int> fractionListofbinary = new List<int>();
            if (number < 0) { integralListofbinary.Add(1); }
            else { integralListofbinary.Add(0); }
            while (integralofNumber > 0)
            {
                temp1 = integralofNumber % 2;
                number = number / 2;
                integralListofbinary.Add(temp1);
            }
            invert(integralListofbinary);
            while (fractionListofbinary.Count <= integralListofbinary.Count)
            {
                fractionofNumber = fractionofNumber * 2;
                temp2= (int)Math.Floor(fractionofNumber);
                fractionofNumber =fractionofNumber - temp2;
                fractionListofbinary.Add(temp2);
            }
            invert(integralListofbinary);
            List <int> result = new List <int>(
               integralListofbinary.Count() + integralListofbinary.Count());
            result.AddRange(fractionListofbinary);
            result.AddRange(integralListofbinary);

            return result;
        }
              
        /// <summary>
        /// invert the Listofbinary
        /// </summary>
        /// <param name="norm"></param>
        /// <returns></returns>
        public static int invert(List<int> norm)
        {
            int[] s = new int[norm.Count];
            for (int i = norm.Count - 1; i >= 0; i--)
            {
                s[norm.Count - 1 - i] = norm[i];
            }
            return Convert.ToInt32(string.Join<int>("", s));
        }

    }
}
