using System;

namespace Paint_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape sh = new Shape();
            char choise;
            do
            {
                Console.WriteLine();
                Console.WriteLine("-------Menu-------");
                Console.WriteLine("1. Add a line");
                Console.WriteLine("2. Add a triagle");
                Console.WriteLine("3. Add a rectangle");
                Console.WriteLine("4. Add a circle");
                Console.WriteLine("5. Add a angle");
                Console.WriteLine("6. Add a egde");
                Console.WriteLine("7. Exit");
                Console.WriteLine();
                Console.WriteLine("Enter your choise: ");
                choise = Convert.ToChar(Console.ReadLine());

                switch (choise)
                {
                    case '1':
                        Console.WriteLine("Class line");
                        // Line line = new Line();
                        // line.input();
                        // abcxyz();
                        break;
                    case '2':
                        Console.WriteLine("");
                        break;
                    case '3':
                        Console.WriteLine("");
                        break;
                    case '4':
                        Console.WriteLine("");
                        break;
                    case '6':
                        Console.WriteLine("");
                        break;
                    case '7':
                        break;
                    default:
                        Console.WriteLine("Invalid choise.");
                        break;
                }                
            }
            while (choise != 5);
        }
    }
}
