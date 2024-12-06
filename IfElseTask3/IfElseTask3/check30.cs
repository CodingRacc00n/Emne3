using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseTask3
{
    internal class check30
    {
        public static bool Main()
        {
            int num = 17;
            int num2 = 13;

            if (num + num2 == 30)
            {
                Console.WriteLine("The number is 30");
                return true;
            }
            else
            {
                Console.WriteLine("The number is not 30");
                return false;
            }
        }
    }
}
