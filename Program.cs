using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace bagtask
{
    public class program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("--------------------------------\n");
            Console.WriteLine("Object oriented programming\n");
            Console.WriteLine("Bag implementation\n");
            Console.WriteLine("Assignment 1, task 9\n");
            Console.WriteLine("Made by: Illia Takhtamyshev\n");
            Console.WriteLine("Neptun: RP0KRP\n");
            Console.WriteLine("Group: 06\n");
            Console.WriteLine("E-mail: takhtamyshev17@gmail.com\n");
            Console.WriteLine("--------------------------------\n");

            Menu start = new Menu();
            start.Run();
        }
    }
}