// See https://aka.ms/new-console-template for more information
Console.WriteLine("Who would like a hobby?");

string name = Console.ReadLine();

string[] hobbies =
{
    "playing hopskotch with illegal cats",
    "stealing with raccoons",
    "farting on people with skunks",
    "biting people with possums",
    "noodling with ferrets",
    "bEing imposter raccoons with red pandas",
    "laughing with foxes"
};

Random rand = new Random();
var randomHobby = rand.Next(0, hobbies.Length);
Console.WriteLine(name + " is " + hobbies[randomHobby]);