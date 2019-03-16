using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Order
{
    //class Program
    //{
        public static class Kata
        {
        
            static void Main()
            {
                ReversedOrder(12345);
            }

            public static int ReversedOrder(int num)
            {
                if (num <= 10)
                {
                    ReversedOrder(num / 10);              
                }
            //Console.WriteLine(num);
            Console.WriteLine(num % 10);
            //Console.ReadLine();
            return 0;
            }
        }
    //}
    
}
// create a fuction that will take an integer and reverse the order

// ex
// Input: 21445 Output: 54412

// Input: 145263 Output: 362541

// Input: 1254859723 Output: 3279584521
