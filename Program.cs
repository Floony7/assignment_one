using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_one_fred_lunjevich
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Console.WriteLine("CALCULATION");
            
            int i = 0;
            while (i < 40) {
                Console.Write("*");
                i++;
            }
            Console.WriteLine("");
            // Main menu items
            while (true) {
                Console.WriteLine("1 - Calculation");
                Console.WriteLine("2 - Exit");
                Console.WriteLine("Please enter your option here: ");
                int option = Int32.Parse(Console.ReadLine());
                if (option == 2)
                {
                    break;
                }
                else if (option == 1)
                {
                    Console.WriteLine("New menu");
                    break;
                }
            }

            
            Console.ReadKey(); */
            
            Console.WriteLine("CALCULATION");

            int i = 0;
            while (i < 40)
            {
                Console.Write("*");
                i++;
            }
            Console.WriteLine("");
            Console.WriteLine("1 - Calculation");
            Console.WriteLine("2 - Exit");
            Console.WriteLine("Please enter your option here: ");
            int option = Console.ReadLine();
            if (option == 1)
            {
                Console.WriteLine("Print new menu");
            } else if (option == 2)
            {
                Environment.Exit(0);
            } else 
            {
                Console.WriteLine("INVALID option");
            }
            Console.ReadKey();
        }
    }
}
