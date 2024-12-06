using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseTask2
{
    internal class Math
    {
        public static int Main()
        {
            int number = 6;
            int number2= 9;

            if (number == number2)
            {
                Console.WriteLine(number * number2);
                return (number * number2);
            }
            else
            {
                Console.WriteLine(number + number2);
                return (number + number2);
            }
        }
        
    }
}
