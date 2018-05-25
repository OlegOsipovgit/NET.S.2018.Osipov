using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossword2
{
    class Program
    {
        public static void Main()
        {

            int temp=0;
            string[,] crosswordfield = new string[100, 100];
            
            ///записываем первое слово из jaggedarray в кроссворд
            for (int i=50;i<51;i++)
            {
                
                int b = 0;
                for (int j = 50; j < Class1.arrays[0].Length + 50; j++)
                {
                    crosswordfield[i, j] = Class1.arrays[Class1.a][b];
                    b++;
                 }
                Class1.a++;
            }
            
            ///Алгоритм поиска места для слова из jaggedarray в сетке кроссворда по совпадению букв
            for (int i=0;i<100;i++)
            {
                for (int j=0;j<100;j++)
                {
                    for(int c=Class1.a ;c<Class1.arrays.Length;c++)
                    {
                        for (int b=0;b<Class1.arrays[c].Length;b++)
                        {
                            ///проверка совпадения букв из существующего слова в кроссворде и записываемого                           
                            if (crosswordfield[i, j] == Class1.arrays[c][b])
                            {
                                ///проверка по вертикали
                                if (crosswordfield[i, j - 1] == null && crosswordfield[i, j + 1] == null)
                                {
                                    ///Проверка на перечесчения с другими словами по вертикали
                                    for (int q=1;q<2;q++)
                                    {
                                        for (int w=j-Class1.arrays[c].Length;w!=j+Class1.arrays[c].Length-b; w++)
                                        {
                                            for(int n=0;n<Class1.arrays.Length;n++)
                                            {
                                                if (crosswordfield[q, w] != null && crosswordfield[q, w] != Class1.arrays[c][n])
                                                {
                                                    temp++;
                                                }
                                            }
                                            
                                        }
                                        
                                    }
                                    if (temp > 0) break;
                                    ///записываем окончание слово в кроссворд по вертикали начиная с общей буквы
                                    for (int n = b; n < Class1.arrays[c].Length; n++)
                                    {
                                        crosswordfield[i, j] = Class1.arrays[c][n];
                                        j++;
                                    }
                                    ///записываем начало слово в кроссворд по вертикали до общей буквы
                                    for (int n = b - 1; n != 0; n--)
                                    {
                                        crosswordfield[i, j - 1] = Class1.arrays[c][n];
                                        j--;
                                    }
                                    Class1.a++;
                                }
                                ///проверка по горизонтали
                                if (crosswordfield[i-1, j] == null && crosswordfield[i+1, j ] == null)
                                {
                                    ///Проверка на перечесчения с другими словами по горизонтали
                                    for (int w = j - Class1.arrays[c].Length; w != j + Class1.arrays[c].Length - b; w++)
                                    {
                                        for (int q = 1; q < 2; q++)
                                        {
                                            for (int n = 0; n < Class1.arrays.Length; n++)
                                            {
                                                if (crosswordfield[q, w] != null && crosswordfield[q, w] != Class1.arrays[c][n])
                                                {
                                                    temp++;
                                                }
                                            }

                                        }

                                    }
                                    if (temp > 0) break;
                                    ///записываем окончание слово в кроссворд по горизонтали начиная с общей буквы
                                    for (int n = b; n < Class1.arrays[c].Length; n++)
                                    {
                                        crosswordfield[i, j] = Class1.arrays[c][n];
                                        i++;
                                    }
                                    ///записываем начало слово в кроссворд по горизонтали до общей буквы
                                    for (int n = b - 1; n != 0; n--)
                                    {
                                        crosswordfield[i-1, j] = Class1.arrays[c][n];
                                        i--;
                                    }
                                    Class1.a++;
                                }
                                else continue;
                            }      
                         }
                        
                     }
                    
                }
            }
           
        }
    }
}
