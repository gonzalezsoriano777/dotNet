using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// create a fuction that will take an integer and reverse the order

namespace dotNet
{
    public static class Kata
    {
       static void Main()
        {
            int result = ReverseOrder(45678);
            Console.WriteLine("The # provided is now Reversed to {0}!", result);
            Console.ReadLine();

        }

        public static int ReverseOrder(int num)
        {
            // Reversed # output called
            int output = 0;

            while(num > 0)
            {
                int reverser = num % 10;

                // store the reverser in output
                output = (num * 10) + reverser;

                // Console.WriteLine("This is where the # will be reversed", output);
                Console.ReadLine();

            }


            return output;

            
        }
    }
}
