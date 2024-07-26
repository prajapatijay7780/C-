using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace min
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
            int min = a[0, 0];
            Console.WriteLine("minimum number :- ");
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (a[row, col] < min)
                    {
                        min = a[row, col];
                    }
                }
            }
            Console.Write(min);

            Console.ReadKey();
        }
    }
}
