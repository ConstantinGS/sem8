using System;
namespace ConsoleApp
{
    class Programm
    {
        static void Main(string[] args)

        { 
          
            int [,] array = new int[4,4];
         
            int i =0;
            int j = -1;
            int count = 0;
            int row = 4;
            int merker = 0;

              

                Counter(3);
                row--;
                while(count<16)
                {
                    Counter(merker);
                    if (merker >= 4 ) merker = 1; 
                    else 
                    {  
                        if (merker%2>0 ) row--;
                        merker ++;
                    }
                } 



                void Counter(int flag)
                {
                    for (int k = 0; k<row; k++)
                    {          
                        if (flag == 1) j--;
                        else if (flag == 2) i--;
                        else if (flag == 3) j++;
                        else i++;
                        count++;
                        array[i,j] = count;
                    }
                } 

               

            for (int z = 0; z<4; z++)
            {
                for (int x = 0; x<4; x++)
                {
                Console.Write($" {array[z,x]} ");
                }
                Console.WriteLine();
            }










        }

    }
}