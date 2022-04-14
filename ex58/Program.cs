using System;
namespace ConsoleApp
{
    class Programm
    {
        static void Main(string[] args)

        { 

            // Задача 58: Задайте две матрицы. Напишите программу, которая будет 
            // находить произведение двух матриц.

            int[,] arrayDouble_1 = new int[3,3];
            int[,] arrayDouble_2 = new int[3,3];

            
            
            MulArray(CreateArray(arrayDouble_1), CreateArray(arrayDouble_2));
      
            
            int[,] CreateArray(int [,] array)
            {
                var rand = new Random();
                for (int i=0; i<3; i++)
                {
                    for (int j=0; j<3; j++)
                    {
                        array[i,j] = rand.Next(0, 4);
                        Console.Write($" {array[i,j]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                return array;
            }

            void MulArray(int [,] array1, int [,] array2)
            { 
                int multi = 0;
                int[,] multiArray = new int[3,3];

                for (int i=0; i<3; i++)
                {
                    for (int j=0; j<3; j++)
                    {
                        multi = 0;
                        for (int k=0; k<3; k++)
                        {
                            multi += array1[i,k]*array2[k,j];
                        }

                        Console.Write($" {multi} ");
                    }
                    Console.WriteLine();
                }






            }







        }

    }
}