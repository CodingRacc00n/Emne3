using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Else_task_1
{
    internal class IfElseTask1
    {
        private int number = 4;
        private int number2 = 5;

        public bool NumbersEqual(int number, int number2)
        {
            if(number == number2)
            {
                Console.WriteLine("The numbers are equal");
                return true;
            }
            else
            {
                Console.WriteLine("The numbers are not equal");
                return false;
            }
        }
    }
}
