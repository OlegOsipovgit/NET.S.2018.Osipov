using System;
using System.Collections.Generic;
using System.Text;

namespace Crossword
{
    class Program
    {
        public static void Main()
        {

            string[,] crosswordfield = new string[11, 11];

            for (int i = 0; i < crosswordfield.GetLength(0); i++)
            {
                for (int j = 0; j < crosswordfield.GetLength(1); j++)
                {
                    if ((i == 0) && (j == 1))
                    {
                        for (int a = 0; a < 1; a++)
                        {
                            for (int b = 1; b < Class1.arrays[0].Length + 1; b++)
                                crosswordfield[a, b] = Class1.arrays[a][b];
                        }
                    }
                    if ((i == 4) && (j == 2))
                    {
                        for (int a = 4; a < 5; a++)
                        {
                            for (int b = 2; b < Class1.arrays[1].Length + 2; b++)
                                crosswordfield[a, b] = Class1.arrays[a][b];
                        }
                    }
                    if ((i == 7) && (j == 0))
                    {
                        for (int a = 7; a < 8; a++)
                        {
                            for (int b = 0; b < Class1.arrays[2].Length; b++)
                                crosswordfield[a, b] = Class1.arrays[a][b];
                        }
                    }
                    if ((i == 7) && (j == 0))
                    {
                        for (int a = 9; a < 10; a++)
                        {
                            for (int b = 1; b < Class1.arrays[3].Length + 1; b++)
                                crosswordfield[a, b] = Class1.arrays[a][b];
                        }
                    }
                    if ((i == 4) && (j == 0))
                    {
                        for (int a = 4; a < Class1.arrays[4].Length + 4; a++)
                        {
                            for (int b = 0; b < 1; b++)
                                crosswordfield[a, b] = Class1.arrays[a][b];
                        }
                    }
                    if ((i == 6) && (j == 3))
                    {
                        for (int a = 6; a < Class1.arrays[5].Length + 6; a++)
                        {
                            for (int b = 3; b < 4; b++)
                                crosswordfield[a, b] = Class1.arrays[a][b];
                        }
                    }
                    if ((i == 0) && (j == 6))
                    {
                        for (int a = 0; a < Class1.arrays[6].Length; a++)
                        {
                            for (int b = 6; b < 7; b++)
                                crosswordfield[a, b] = Class1.arrays[a][b];
                        }
                    }


                }

            }
        }
    }
}

