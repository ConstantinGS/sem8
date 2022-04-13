using System;
namespace ConsoleApp
{
    class Programm
    {
        static void Main(string[] args)

        { 

        

            int[,] arrayDouble = new int[5,5];
            var rand = new Random();
            orderArray(createArray(arrayDouble));

            int[,] createArray(int [,] array)
            {
                for (int i=0; i<5; i++)
                {
                    for (int j=0; j<5; j++)
                    {
                        array[i,j] = rand.Next(0, 2);
                        Console.Write($" {array[i,j]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                return array;
            }


            void orderArray(int [,] arrayD)
            {
                Console.WriteLine($"Строкой с максимальной суммой является: ");
                
                int[] arraySum = new int[5];
                int max = 0;

               

                for (int k=0; k<5; k++)
                { 
                    int sum = 0;
                    for (int i=0; i<5; i++)
                        { 
                            sum += arrayD[k, i]; 
                        }
                    arraySum[k] = sum;                      
                }
                for (int i=0; i<4; i++)
                { 
                    if ( arraySum[i]<arraySum[i+1])
                    {
                        max = arraySum[i+1];
                    }
                }
                for (int i=0; i<5; i++)
                { 
                    if ( arraySum[i]==max)
                    {
                        int max_row = i+1;
                        Console.WriteLine($"{max_row}ая  -  {max} ");
                    }
                }
                    


                
               
            }

            





 



        }

    }
}