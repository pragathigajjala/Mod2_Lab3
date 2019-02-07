//This Program displays prime numbers up to 10
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int outer;
            int inner;

            for (outer=2; outer<10; outer++)
            {
                for (inner = 2; inner <= (outer / inner); inner++)
                    if ((outer % inner) == 0 )break;//if factor found, not prime
                    if (inner > (outer / inner))
                    Console.WriteLine("{0} is prime", outer);

            }


        }  
    }
}
