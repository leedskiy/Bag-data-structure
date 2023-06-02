using System;

namespace bagtask
{
    class Menu
    {
        private Bag bag = new Bag();

        public void Run()
        {
            int n;

            do
            {
                n = getN();

                switch(n)
                {
                    case 1:
                        AddElem();
                        print();
                        break;
                    case 2:
                        popElem();
                        print();
                        break;
                    case 3:
                        receiveFreq();
                        print();
                        break;
                    case 4:
                        receiveOcc1Els();
                        print();
                        break;
                    case 5:
                        print();
                        break;
                    default:
                        Console.WriteLine("--------------------------------\n");
                        Console.WriteLine("End of the program\n");
                        Console.WriteLine("--------------------------------\n");
                        break;
                }
            } while (n != 0);
        }

        private int getN() 
        {
            int n;
            
            do
            {
                Console.WriteLine("--------------------------------\n");
                Console.WriteLine("Choose from the options:\n");
                Console.WriteLine("0 - exit");
                Console.WriteLine("1 - insert an element");
                Console.WriteLine("2 - remove an element");
                Console.WriteLine("3 - return the frequency of element");
                Console.WriteLine("4 - return num of elems which occur only once");
                Console.WriteLine("5 - print the bag\n");
                Console.Write("Your number: ");

                try
                {
                    n = int.Parse(Console.ReadLine());
                }
                catch(System.FormatException)
                {
                    n = -1;
                    Console.WriteLine("\nThe number has to be of type int");
                }

                Console.WriteLine();
            } while(n < 0 || n > 5);

            return n;
        }

        private void AddElem()
        {
            Console.Write("Give an element to insert: ");

            try
            {
                int n = int.Parse(Console.ReadLine());
                bag.insertElem(n);
            }
            catch(System.FormatException)
            {
                Console.WriteLine("\nThe element has to be of type int");
            }

            Console.WriteLine();
        }

        private void popElem()
        {
            int n;
            Console.Write("Give an element to remove: ");

            try
            {
                n = int.Parse(Console.ReadLine());
            }
            catch(System.FormatException)
            {
                Console.WriteLine("\nThe element has to be of type int\n");
                return;
            }

            try
            {
                bag.removeElem(n);
            }
            catch(Bag.cantFindElem)
            {
                Console.WriteLine("\nThe element does not exist");
            }

            Console.WriteLine();
        }

        private void receiveFreq()
        {
            int n;
            Console.Write("Give an element to get its frequency: ");

            try
            {
                n = int.Parse(Console.ReadLine());
                Console.WriteLine($"\nFrequency of element {n} is {bag.getFreq(n)}\n");
            }
            catch(System.FormatException)
            {
                Console.WriteLine("\nThe element has to be of type int\n");
                return;
            }
        }

        private void receiveOcc1Els()
        {
            Console.WriteLine($"Number of elements which occur only once: {bag.getOcc1Els()}\n");
        }

        private void print()
        {
            Console.WriteLine("Current state of bag (elem, occ):\n");

            if(bag.getSize() != 0)
            {
                Console.WriteLine($"{bag}\n");
            }
            else
            {
                Console.WriteLine("The bag is empty\n");   
            }

            Console.WriteLine("--------------------------------\n");
        }
    }
}