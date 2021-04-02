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
                Console.WriteLine("                 4) Peek last object                              ");
                Console.WriteLine("                 5) Is it stack conteins item?                    ");
                Console.WriteLine("                 6) End program.                                  ");
                Console.WriteLine("==================================================================");
                Console.Write(" Make your choice    :   "); ch = Console.ReadLine();
                if (ch == "6") Eexit = true;
                else
                {
                    if (ch == "1")
                    {
                        Console.WriteLine("Input elements in stack, and press Esc to end.");
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
                    }
                    if ((ch == "2") & (stack.ElementCount >= 1))
                    {
                        Console.WriteLine("Items from Stack.");
                        do
                        {
                            Console.WriteLine(stack.Pop());
                        }
                        while (stack.ElementCount > 0);
                    }
                    else if ((ch == "2") & (stack.ElementCount == 0))
                            { 
                                Console.WriteLine("Stack is empty now.");
                            }
                    if (ch == "3") 
                    { 
                        stack.Clear(); 
                        Console.WriteLine("Stack empted.");
                    }
                    if (ch == "4")
                    {
                        if (stack.ElementCount > 0) Console.WriteLine("Last element in stack:   {0}", stack.Peek());
                        if (stack.ElementCount == 0) Console.WriteLine("Stack is empty now.");
                    }
                    if (ch == "5")
                    {
                        if (stack.ElementCount == 0) Console.WriteLine("Stack is empty now.");
                        else 
                        {
                            Console.WriteLine("Input an element to check if it is on the stack");
                            Console.Write("x = "); object e = Console.ReadLine();
                            stack.Peek(e);
                        }
                        
                    }
                    Console.WriteLine("\nPress any key...");
                    Console.ReadLine();
                }
            }
        }
    }
}




