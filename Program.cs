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
            Console.WriteLine("Bag implementation\n");
            Console.WriteLine("Made by: Illia Takhtamyshev\n");
            Console.WriteLine("--------------------------------\n");

            Menu start = new Menu();
            start.Run();
        }
    }
}