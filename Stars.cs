using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, b, rows;

            Console.WriteLine("Enter a number");
            rows = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= rows; i++)
            {
          
                for (b = 1; b <= i; b++)
                {

                    
                    Console.Write("{0}", b );
                    
                }
                for(int c = b; c <= rows; c++)
                {
                    Console.Write("*");
                }
                
                    
                Console.Write("\n");
            }
        }
    }

   
}


