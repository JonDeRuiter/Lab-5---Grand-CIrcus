using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_Factorals
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            long num, result;
            while (run)
            {
                                
                //When sent through the factorial method, 20 is the max int that long can hold without overflowing
                Console.Write("Please enter an integer from 1 to 20: ");
                //Factoral(Console.ReadLine());
                num = long.Parse(Console.ReadLine());
                result = Factorial(num);

                Console.WriteLine("The factorial of {0} is {1}.", num, result);

                run = Continue();
            }
        }

        //public static void Factorial(string input)
        //{
        //    int x;
        //    long f = 1;
            
        //    x = int.Parse(input);
        //    for (int i = 1; i <= x; i++)
        //    {
        //        f = f * i;
        //    }
        //    Console.WriteLine("The factorial of {0} is {1}.", x, f);
        //}

        
        public static long Factorial(long x)
        {
            if (x == 1)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
          }
               
        public static bool Continue()
        {
            bool run;
            Console.WriteLine("Continue? y/n");
            string answer = Console.ReadLine();
            answer = answer.ToLower();

            if (answer == "y")
            {
                run = true;
            }
            else if (answer == "n")
            {
                run = false;
            }
            else
            {
                Console.WriteLine("Sorry, I didn't understand that. Try again.");
                run = Continue();
            }
            return run;
        }
    }
}
