using System;
namespace ConsoleApp
{
    class Programm
    {
        static void Main(string[] args)

        { 

            int[] array_1 = arrayDN(3,3,3);
            int count = 0;
            int[,,] array3D = new int[3,3,3];

            for (int i=0; i<3; i++)
            {
                for (int j=0; j<3; j++)
                {
                    for (int k=0; k<3; k++)
                    {
                        array3D[i,j,k] = array_1[count];
                        count++;
                        Console.WriteLine($" {count}ый  элемент с индексом {i},{j},{k} равен {array3D[i,j,k]} "); 
                    }
                }
            }




            
            

            int[] arrayDN(int row1, int row2, int row3)
            {
                int mul = row1*row2*row3;
                int[] array = new int[mul];
                int[] array_numbers = new int [90];
                var rand = new Random();
                int k = 0;

                for (int i = 0; i<90; i++)
                {
                    array_numbers[i] = i+10;
                }
                
                while(k<mul)
                {
                    int randNumber = rand.Next(10, 100);
                    for (int i = 0; i<90-k; i++)
                    {
                        if (array_numbers[i]==randNumber)
                        {
                            array[k] = randNumber;
                            Array.Clear(array_numbers, i, 1);
                            k++;
                        }
                    }
                }
                return array;
            }




         





        }

    }
}