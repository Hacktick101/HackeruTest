using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTotal
{
    class Program
    {
        static void Main(string[] args)
        {
            int secondsTotal;
            Console.WriteLine("enter a positive number");
            secondsTotal = Convert.ToInt32(Console.ReadLine());
            if (secondsTotal > 0)
            {
                ConvertTime(secondsTotal);

            }
            else
            {
                Console.WriteLine("Error number must be positive!");
            }
        }
        static void ConvertTime(int a)
        {
            int days = a / (24 * 3600);
            a = a % (24 * 3600);
            int hours = a / 3600;

            a %= 3600;
            int minutes = a / 60;

            a %= 60;
            int seconds = a;

            Console.WriteLine("Days: " + days + " , hours: " + hours + " , minutes: " + minutes + " , seconds: " + seconds);
                


        }



    }
}
