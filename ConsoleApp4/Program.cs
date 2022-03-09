using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
            
            {
            int[] arr = { 1, 3, 4, 7, -9, 2, -5 };

            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] < 0)

                {
                    int son = arr[i] * -1;

                    Console.WriteLine(son);

                }
                //menfini musbet etdikden sonra, umumi massivi geri qaytara bilmirem(((;
            }
        }
     
        

        }


    }

