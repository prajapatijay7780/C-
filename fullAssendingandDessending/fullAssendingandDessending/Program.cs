using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullAssendingandDessending
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 3];
            Console.WriteLine("Enter your 3X3 Matrix :- ");
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write("a[{0}][{1}]  :- ", row, col);
                    a[row, col] = Convert.ToInt32(Console.ReadLine());

                }
            }
            Console.WriteLine("3X3 Matrix :- ");
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write("{0}\t", a[row, col]);
                }
                Console.WriteLine("");
            }
            int num;
            Console.WriteLine("Full-Assending number :- ");
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        for (int l = 0; l < 3; l++) { 
                            if (a[row, col] < a[k,l])
                            {
                                num = a[row, col];
                                a[row, col] = a[k,l];
                                a[k,l] = num;
                            }
                        }
                    }
                }
            }

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write("{0}\t", a[row, col]);
                }
                Console.Write("\n");
            }
            Console.WriteLine("Full-Dessending number :- ");
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        for (int l = 0; l < 3; l++)
                        {
                            if (a[row, col] > a[k, l])
                            {
                                num = a[row, col];
                                a[row, col] = a[k, l];
                                a[k, l] = num;
                            }
                        }
                    }
                }
            }

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write("{0}\t", a[row, col]);
                }
                Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}
