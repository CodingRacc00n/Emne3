﻿// See https://aka.ms/new-console-template for more information
bool isRunning = true;
while(isRunning){
    Console.WriteLine("Choose a number of a weekday");
    string weekday = Console.ReadLine();
    isRunning = false;
    switch (weekday)
    {
        case "1":
            Console.WriteLine("Monday");
            break;
        case "2":
            Console.WriteLine("Tuesday");
            break;
        case "3":
            Console.WriteLine("Wednesday");
            break;
        case "4":
            Console.WriteLine("Thursday");
            break;
        case "5":
            Console.WriteLine("Friday");
            break;
        case "6":
            Console.WriteLine("Saturday");
            break;
        case "7":
            Console.WriteLine("Sunday");
            break;
        default:
            isRunning = true;
            break;
    }
}