using System.Security.Cryptography.X509Certificates;

namespace Variabeltolordning_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tall1 = 4;
            int tall2 = 5;

            string tekst = "Denne metoden returnerer ingenting";

            int ReturnWholeNumber(int number, int number2)
            {
                return number + number2;
            }

            string ReturnString()
            {
                return tekst;
            }

            Console.WriteLine($"this is an int: {ReturnWholeNumber(tall1 , tall2)}");
            Console.WriteLine($"{ReturnString()}");

        }
    }
}