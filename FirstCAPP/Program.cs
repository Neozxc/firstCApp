﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string characterName = "Test";
            // int characterAge;
            // characterAge = 35;


            // Console.WriteLine("Hello! " + characterName + "Your age is: " + characterAge);

            // characterName = "New Test";
            // Console.WriteLine("Your name changed to: " + characterName);
            // Console.ReadLine();

            // string phrase = "Testing";
            // One character with char
            // char gradeu = "A";
            // int age = 30;

            // If you want to be precise and exact use
            // decimal for example 3.2
            // float will be less precise
            // and double is just right there in the middle.

            // float, double, decimal

            // bool for booleans = true = false

            // string testing = "Testing\nHehe!";

            // Console.WriteLine(testing);


            // Simple application, get user input and output to the screen!
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine(name);

            Console.Write("How old are you? " + name + "");
            string age = Console.ReadLine();
            Console.WriteLine("My name is " + name + " And i am " + age + " years old.");


            Console.ReadLine();
        }
    }
}
