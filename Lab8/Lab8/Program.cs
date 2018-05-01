using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat)
            {
                string[] Names = { "Jason", "Kamel", "Riyad", "Mike", "Toni", "Tim", "Anna", "Anthony", "Sarah", "Racheal", "Jasmine", "Mcmike" };
                string[] FavFood = { "Cake", "Fries", "BK", "Chips", "Samoas", "Pork Rinds", "Salmon", "Sonic", "Yogurt", "Apples", "7up Cake", "Cannolis" };
                string[] Hometown = { "Royal Oak", "Troy", "Frankenmuth", "Tulsa", "Dallas", "Ft Wayne", "Petoskey", "Rochester Hills", "Farmington", "Grand Rapids", "Northville", "Southfield" };
                int Namind;
                Console.WriteLine("Welcome to Grand Circus C# Class April 2018!!");
                Console.WriteLine("Please enter a number from 1 - 12 to access a profile");
                while (!int.TryParse(Console.ReadLine(), out Namind) || Namind < 1 || Namind > 12)
                {
                    Console.WriteLine("Invalid input");
                    Console.WriteLine("Please enter a number from 1 - 12 to access a profile");
                }

                Console.WriteLine(Names[Namind - 1]);

                Console.WriteLine($"Would you like to know {Names[Namind - 1]}'s hometown(h) or favorite food(f)?");
                string input = Console.ReadLine().ToLower();
                while (input != "h" && input != "f" && input != "n")
                {
                    Console.WriteLine("Please enter (h) or (f). or press (n) to choose a different student");
                    input = Console.ReadLine().ToLower();
                }
                if (input == "h")
                {
                    Console.WriteLine($"{Names[Namind - 1]}'s hometown is {Hometown[Namind - 1]}");
                    Console.WriteLine($"Would you like to know {Names[Namind - 1]}'s favorite food(f)? or (n)?");
                    input = Console.ReadLine().ToLower();
                    while (input != "f" && input != "n")
                    {
                        Console.WriteLine("Please enter (f). or press (n) to choose a different student");
                        input = Console.ReadLine().ToLower();
                    }
                    if (input == "f")
                    {
                        Console.WriteLine($"{Names[Namind - 1]}'s favorite is {FavFood[Namind - 1]}");
                        repeat = Continue("Would you like to choose a different student? (Y) or quit? (N)");
                    }
                    if (input == "n")
                    {
                        repeat = Continue("Would you like to choose a different student? (Y) or quit? (N)");
                    }
                }
                else if (input == "f")
                {
                    Console.WriteLine($"{Names[Namind - 1]}'s favorite is {FavFood[Namind - 1]}");
                    Console.WriteLine($"Would you like to know {Names[Namind - 1]}'s hometown(h)? or (n)?");
                    input = Console.ReadLine().ToLower();
                    while (input != "h" && input != "n")
                    {
                        Console.WriteLine("Please enter (h). or press (n) to choose a different student");
                        input = Console.ReadLine().ToLower();
                    }
                    if (input == "h")
                    {
                        Console.WriteLine($"{Names[Namind - 1]}'s hometown is {Hometown[Namind - 1]}");
                        repeat = Continue("Would you like to choose a different student? (Y) or quit? (N)");
                    }
                    if (input == "n")
                    {
                        repeat = Continue("Would you like to choose a different student? (Y) or quit? (N)");
                    }
                }
                else if (input == "n")
                {
                    repeat = Continue("Would you like to choose a different student? (Y) or quit? (N)");
                }

            }
        }
        public static bool Continue(string Message)
        {
            while (true)
            {
                Console.WriteLine(Message);
                string input = Console.ReadLine().ToUpper();
                if (input == "N")
                {
                    return false;
                }
                else if (input == "Y")
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid input, try again");
                }
            }


        }
    }
}
