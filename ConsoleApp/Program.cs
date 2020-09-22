using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMenu();
            string input = Console.ReadLine();
            Console.WriteLine();

            while (input.ToLower() != "q")
            {
                switch (input)
                {
                    case "1": DesignPatterns.Behavioral.Command.Client.Run(); break;
                    default: return;
                }
                Console.WriteLine();

                ShowMenu();
                Console.WriteLine("Press q to finish");
                Console.WriteLine();

                input = Console.ReadLine();
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("Behaviour patterns:");
            Console.WriteLine(" + Command - 1;");
            Console.WriteLine();
        }
    }
}
