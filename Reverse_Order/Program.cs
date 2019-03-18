using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Order
{
        public static class Kata
        {
            
            static void Main()
            {
                int result = ReversedOrder(12345);
                Console.WriteLine("The number in ReversedOrder is {0}",result);     
                Console.ReadLine();
            }

            public static int ReversedOrder(int num)
            {   
                int ReversedOutput = 0;
                                   
                 while(num > 0)
                {   
                    //GRABS LAST NUMBER
                    int IndRevNumber = num % 10;

                    //STORES THE LAST NUMBER
                    ReversedOutput = (ReversedOutput * 10) + IndRevNumber;
                    
                    //REMOVES THE LAST NUMBER FROM INT GIVEN
                    num = num / 10;

                    Console.WriteLine(IndRevNumber);
                    Console.WriteLine("Numbers remaining: {0} ",num);
                    Console.ReadLine();
                }
                 //Console.WriteLine(ReversedOutput);
                 //Console.ReadLine();
                 return ReversedOutput;
            
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
