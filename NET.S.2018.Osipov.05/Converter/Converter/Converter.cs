using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
           /// <summary>
        /// Class converter 
        /// </summary>
        public static class Converter
        {
            /// <summary>
            /// Converting to decimal method
            /// </summary>
            /// <param name="value"></param>
            /// <param name="bitnessofvalue"></param>
            /// <returns></returns>

            public static int ToDecimal(string value, int bitnessofvalue)
            {

                const string sequence = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                int rank = 1, result = 0;

                for (var i = value.Length - 1; i >= 0; i--)
                {
                    var index = sequence.IndexOf(value[i]);
                    if (index < 0 || index >= bitnessofvalue)
                        throw new ArgumentException();
                    result += rank * index;
                    rank *= bitnessofvalue;
                }
                if (result < 0)
                    throw new OverflowException();
                return result;
            }
        }
   }
