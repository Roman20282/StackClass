using System;
using System.Text;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            
            string ch;
            bool Eexit = false;
            while (!Eexit)
            {
                Console.Clear();
                Console.WriteLine("****************Program using class Stack().**********************");
                Console.WriteLine("==================================================================");
                Console.WriteLine("                 1) Push objects in Stack                         ");
                Console.WriteLine("                 2) Pop objects from Stack                        ");
                Console.WriteLine("                 3) Clear Stack                                   ");
                Console.WriteLine("                 4) End program.                                  ");
                Console.WriteLine("==================================================================");
                Console.Write(" Make your choice    :   "); ch = Console.ReadLine();
                if (ch == "4") Eexit = true;
                else
                {
                    if (ch == "1")
                    {
                        Console.WriteLine("Press Esc to exit.");
                        ConsoleKeyInfo input;
                        do
                        {
                           input = Console.ReadKey(true);
                           if (input.Key != ConsoleKey.Escape)
                            {
                                Console.WriteLine(input.Key.ToString());
                                stack.Push(input.Key.ToString());
                            }

                        } while (input.Key != ConsoleKey.Escape);
                        Console.WriteLine("Items in Stack.");
                        Console.WriteLine("Press any key...");
                        Console.ReadLine();

                    }
                    if ((ch == "2") & (stack.ElementCount > 0))
                    {
                        Console.WriteLine("Items from Stack.");
                        do
                        {
                            Console.WriteLine(stack.Pop());
                        }
                        while (stack.ElementCount > 0);
                        Console.WriteLine("Press any key...");
                        Console.ReadLine();
                    }
                    else if ((ch == "2") & (stack.ElementCount == 0)){ 
                            Console.WriteLine("Stack empty");
                            Console.WriteLine("Press any key...");
                            Console.ReadLine(); 
                    }
                    if (ch == "3") { stack.Clear(); Console.WriteLine("Stack empty. Press any key..."); Console.ReadLine(); }
                    }
                

            }
        }
    }
}




