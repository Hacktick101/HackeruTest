using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("enter a number between 1 and 1000");
            number = Convert.ToInt32(Console.ReadLine());
            
            if (1 <= number && number < 1001)
            {
                if (Prime(number))
                {
                    Console.WriteLine("It is prime");
                }
                else
                {
                    Console.WriteLine("It is not prime");
                }
             
            }


            
        }
        public static bool Prime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var limit = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= limit; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
