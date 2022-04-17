using System;
namespace ConsoleApp
{
    class Programm
    {
        static void Main(string[] args)

        { 

            //Задача 54: Задайте двумерный массив. Напишите программу, которая 
            // упорядочит по убыванию элементы каждой строки двумерного массива.

            int[,] arrayDouble = new int[5,5];
            var rand = new Random();
            arrayDouble = orderArray(createArray(arrayDouble));

            int[,] createArray(int [,] array)
            {
                for (int i=0; i<5; i++)
                {
                    for (int j=0; j<5; j++)
                    {
                        array[i,j] = rand.Next(0, 10);
                        Console.Write($" {array[i,j]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                return array;
            }


            int[,] orderArray(int [,] arrayD)
            {
               

                for (int k=0; k<5; k++)
                {
                    for (int i=0; i<5; i++)
                        { 
                        for (int j=0; j<5; j++)
                            {
                                if ( arrayD[k,j]<arrayD[k,i])
                                {
                                    int min = arrayD[k,j];
                                    arrayD[k,j]  = arrayD[k,i];
                                    arrayD[k,i] = min;
                                    
                                }
                            }
                            
                        }
 
                }
                return  arrayD;
            }


            for (int i=0; i<5; i++)
            { 
                for (int j=0; j<5; j++)
                {
                    Console.Write($" {arrayDouble[i,j]} ");
                }
   
                Console.WriteLine();  
            }

            





 



        }

    }
}