using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEvklidNOD
{
    /// <summary>
    /// Convert to IEEE754
    /// </summary>
    public static class ToIEEE754
    {
        /// <summary>
        /// double to ieee754
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetBinary(this double value)
        {
            const int bias = 127;
            const int orderSize = 8;
            const int mantisa = 23;
            int sign;
            if (!(value > 0))
                sign = 1;
            else
                sign = 0;
            value = Math.Abs(value);

            int shift = 0;
            var bitCount = sizeof(double) * 8;
            var result = new StringBuilder(bitCount);
            var integerPart = Convert.ToString((int)Math.Truncate(value), 2);
            int pointIndex = integerPart.Length;
            result.Append(integerPart);

            value = value - (int)value;
            int count = 1;
            while (value != 0 && count < mantisa)
            {
                value *= 2;
                int t = (int)value;
                value = value - t;
                result.Append(t);
                count++;
            }

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == '1')
                {
                    if (pointIndex > i)
                    {
                        shift = pointIndex - i - 1;
                        result.Remove(0, i + 1);
                    }
                    else if (pointIndex == i)
                    {
                        shift = -1;
                        result.Remove(0, 2);
                    }

                    break;
                }
            }

            int order = bias + shift;
            string orderBinary = Convert.ToString(order, 2);
            result.Insert(0, orderBinary);
            if (orderBinary.Length < orderSize)
            {
                result.Insert(0, "0", orderSize - orderBinary.Length);
            }

            result.Insert(0, sign == 1 ? '1' : '0');

            if (result.Length < bitCount)
            {
                result.Append('0', bitCount - result.Length);
            }
            else if (result.Length > bitCount)
            {
                result.Remove(bitCount, result.Length - bitCount);
            }

            Console.WriteLine(result.Length);

            return result.ToString();
        }
    }
}
