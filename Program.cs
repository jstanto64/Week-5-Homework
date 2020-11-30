using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Week5Homework
{
    class Program
    {
        static void Main(string[] args)
        {

             /*//Exercise 1
              Console.WriteLine("Please enter a number.");

              int n = Convert.ToInt32(Console.ReadLine());

              for (int i = n; i <= n; i--)
              {
                  Thread.Sleep(1000);
                  Console.WriteLine($"Your number is: {i}");
              }
              Console.ReadLine();


              //Exercise 2
              for (int i = 0; i <= 100; i += 2)
              {
                  Console.WriteLine($"{i}");
              }
              Console.ReadLine();
           */ 

            //Exercise 3
            for (int i = 1; i <= 7; i++)
            {
                for (int a = 1; a <= i; a++)
                {
                    Console.WriteLine($"{a}");
                }
                for (int b = 7 - i; b >= 1; b--)
                {
                    Console.WriteLine("*");
                }
                Console.ReadLine();
            }

                  //Exercise 4
                int c = 0;
                int d = 1;
                int n = 36;
                Console.WriteLine(c + " " + d + " ");
                int nn = c + d;
            for (int i = 2; nn < n; i++)
            {
                Console.WriteLine(nn + " ");
                c = d;
                d = nn;
                nn = c + d;
            }
            Console.ReadLine();


            //Exercise 5
            int rw = 8;
            int co = 8;
            for (int i = 0; i < rw; rw++)
            {
                for (int j = 0; j < co; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.WriteLine("X");
                    }
                    else
                    {
                        Console.WriteLine("O");
                    }
                }
                Console.ReadLine();
            }

                 Console.ReadLine();
            

        }
    }
}