using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvklidNOD
{
    public class EvklidClass
    {
        /// <summary>
        ///NODofElementsEvklid method receives the massive (Numbers) of elements that greatest common divider will be serched
        ///by NOD method
        /// </summary>
        /// <param name="Numbers"></param>
        /// <returns></returns>
        public static int NODofElementsEvklid(params int[] Numbers)
        {
            if (Numbers.Length == 0) return 0;
            Array.Sort(Numbers);
            int i=0;
            int number = Numbers[0];
            for (i = 0; i < Numbers.Length - 1; i++)
                number = NOD(number, Numbers[i + 1]);
            return number;
        }
        /// <summary>
        /// FirstNumber and SecondNumber are the elements that greatest common divisor will be searched
        /// </summary>
        /// <param name="FirstNumber"></param>
        /// <param name="SecondNumber"></param>
        /// <returns></returns>
        public static int NOD(int FirstNumber, int SecondNumber)///greatest common diviser
        {
            while (SecondNumber != 0)
            {
                int temp = SecondNumber;
                SecondNumber = FirstNumber % SecondNumber;
                FirstNumber = temp;
            }
            return FirstNumber;
        }
        /// <summary>
        /// NODofElementsStein method receives the massive (Numbers) of elements that greatest common divider will be serched
        ///by Stein method
        /// </summary>
        /// <param name="Numbers"></param>
        /// <returns></returns>
        public static uint NODofElementsStein(params uint[] Numbers)
        {
            if (Numbers.Length == 0) return 0;
            Array.Sort(Numbers);
            int i = 0;
            uint number = Numbers[0];
            for (i = 0; i < Numbers.Length - 1; i++)
                number = Stein(number, Numbers[i + 1]);
            return number;
        }
        /// <summary>
        /// The Stein method of searching the gcd
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public static uint Stein(uint number1, uint number2)
        {
            if (number1 == 0) return number2;
            if (number2 == 0) return number1;
            if (number1 == number2) return number1;
            bool checkEvenNumber1 = (number1 & 1u) == 0;
            bool checkEvenNumber2 = (number2 & 1u) == 0;

            if (checkEvenNumber1 && checkEvenNumber2)
                return Stein(number1 >> 1, number2 >> 1) << 1;
            else if (checkEvenNumber1 && !checkEvenNumber2)
                return Stein(number1 >> 1, number2);
            else if (checkEvenNumber2)
                return Stein(number1, number2 >> 1);
            else if (number1 > number2)
                return Stein((number1 - number2) >> 1, number2);
            else
                return Stein(number1, (number2 - number1) >> 1);
        }


    }
}
