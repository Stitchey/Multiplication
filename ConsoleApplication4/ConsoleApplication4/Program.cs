using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int loop = 1;
            string restart;

            while (loop == 1)
            {
                // Gångertabellen!
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Enter a Number");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("> ");
                Console.ForegroundColor = ConsoleColor.White;

                number = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("{0} x 1 = {1}", number, number * 1);
                Console.WriteLine("{0} x 2 = {1}", number, number * 2);
                Console.WriteLine("{0} x 3 = {1}", number, number * 3);
                Console.WriteLine("{0} x 4 = {1}", number, number * 4);
                Console.WriteLine("{0} x 5 = {1}", number, number * 5);
                Console.WriteLine("{0} x 6 = {1}", number, number * 6);
                Console.WriteLine("{0} x 7 = {1}", number, number * 7);
                Console.WriteLine("{0} x 8 = {1}", number, number * 8);
                Console.WriteLine("{0} x 9 = {1}", number, number * 9);
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Restart?");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[Yes/No]");
                Console.ForegroundColor = ConsoleColor.White;
                restart = Console.ReadLine().ToLower();

                if(restart == "yes")
                {
                    loop = 1;
                    Console.Clear();
                    continue;
                }
                
                else if(restart == "no")
                {
                    loop = 0;
                }

                else
                {
                    loop = 1;
                    Console.Clear();
                    continue;
                }
            }

        }
    }
}
