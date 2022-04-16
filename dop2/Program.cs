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
          


        Dictionary <int,int> dict_numbers = new Dictionary<int, int>();
        Dictionary <int,int> dict_count = new Dictionary<int, int>();

        for (int i=-9; i<10; i++)
        {
            dict_numbers.Add(i,i);
            dict_count.Add(i,0);
        }


        for (int i = 0; i<4; i++)
            {
                for (int j = 0; j<4; j++)
                {
                    if ( dict_numbers.ContainsValue(array[i,j]))
                    {
                        dict_count[array[i,j]]++;
                    }
                }
            }

        for (int i = -9; i<10; i++)
        {
            Console.WriteLine ($" Количество чисел с ключем {i} равно {dict_count[i]} ");

        }
               

        







          
            int[,] NewArray(int[,] new_array)
            {
                for (int i = 0; i<4; i++)
                {
                    for (int j = 0; j<4; j++)
                    {
                        new_array[i,j] = rand.Next(-9,9);
                        Console.Write($" {array[i,j]} ");
                    }
                    Console.WriteLine();
                }

                return new_array;
            }



             



         




            





        }
    }
}