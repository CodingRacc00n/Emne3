// Lage objekter (Yaniss, Nickolas)
// Objektene skal ha verdier som Navn, alder, og egenskaper.
// Objektene skal også ha ting de liker å gjøre (string som forteller om en ting)

//Meny hvor du velge person og få informasjon om dem.


using System;
using ParProg1;



public class Program
{
    public static void Main(string[] args)
    {
        // Create a list of Person objects
        List<Person> people = new List<Person>();

        // Add Yaniss and Nickolas to the list
        people.Add(new Person("Yaniss", 22, "blonde", "golf"));
        people.Add(new Person("Nickolas", 21, "black", "reading"));


        Console.WriteLine("People List");
        Console.WriteLine("-----------");

        while (true)
        {



            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine($"{i}. {people[i].Name}");
            }

            Console.WriteLine("Select index of person for more (0-1)");

            string userInput = Console.ReadLine();

            if (userInput == "0")
            {
                int index = Convert.ToInt32(userInput);
                Console.WriteLine(
                    $"Person : {people[index].Name} is {people[index].Age} years old. and likes to {people[index].Hobbies}.");
                Console.WriteLine($"Persons haircolor is {people[index].HairColor}!");
            }
            else if (userInput == "1")
            {
                int index = Convert.ToInt32(userInput);
                Console.WriteLine(
                    $"Person : {people[index].Name} is {people[index].Age} years old. and likes to {people[index].Hobbies}.");
                Console.WriteLine($"Persons haircolor is {people[index].HairColor}!");
            } else if (userInput == "exit")
            {
                Environment.Exit(0);
            }
        }
    }
}