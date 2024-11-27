// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;
using System.Threading.Channels;



namespace VirtualPet
{
    internal class Program
    {
        private static Pet pet = new Pet("Maik", 10);
        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            {
                pet.displayStats();
                Console.WriteLine("Hello, World!");

                Console.WriteLine("1.Feed Pet");
                Console.WriteLine("2.Play with Pet");
                Console.WriteLine("3.Take Pet to toilet");
                Console.WriteLine("4. Exit");
            
           
                var MenuInputs = Console.ReadLine();
                switch (MenuInputs)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Feed Pet");
                        pet.FeedPet();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Play with Pet");
                        pet.PlayWithPet();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Take Pet to toilet");
                        pet.TakePetToilet();
                        break;
                    case "4":
                        isRunning = false;
                        break;
                }
            }
        }
    }
}