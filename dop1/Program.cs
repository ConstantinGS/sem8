using System;
namespace ConsoleApp
{
    class Programm
    {
        static void Main(string[] args)

        {
            int rows = 4;
            int colomns = 4;
            int[,] array = new int[rows,colomns];
            var rand = new Random();
            array = NewArray(array);

            int buffer = 0;
                
                for (int j = 1; j<4; j++)
                {
                    buffer = array[j,j];
                    array[3,j] = array[3-j,j];
                    array[0,j] = buffer;
                      
                }

            PrintArray(array);








          
            int[,] NewArray(int[,] new_array)
            {
                for (int i = 0; i<4; i++)
                {
                    for (int j = 0; j<4; j++)
                    {
                        new_array[i,j] = rand.Next(1,10);
                        Console.Write($" {array[i,j]} ");
                    }
                    Console.WriteLine();
                }

                return new_array;
            }


            /* Дан двумерный массив. Заменить в нём элементы первой строки
             элементами главной диагонали. А элементы последней строки, элементами побочной диагонали. */


                     

            void PrintArray(int[,] arrayPr)
            {
                Console.WriteLine();
                for (int i = 0; i<4; i++)
                {
                    for (int j = 0; j<4; j++)
                    {
                    
                        Console.Write($" {arrayPr[i,j]} ");
                    }
                    Console.WriteLine();
                }
            }


             



         




            





        }
    }
}