using System;
using DesignPatterns.Behavioral.Command;

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
                    case "1": Behaviour_Command(); break;
                    default: return;
                }
                Console.WriteLine();

                ShowMenu();
                Console.WriteLine("Press q to finish");
                Console.WriteLine();

                input = Console.ReadLine();
            }
        }

        static void Behaviour_Command()
        {
            Invoker invoker = new Invoker();
            invoker.OnStart = new SimpleCommand("Some simple command");
            Receiver receiver = new Receiver();
            invoker.OnFinish = new ComplexCommand(receiver, "Command A", "Command B");

            invoker.DoSomethingImportant();
        }

        static void ShowMenu()
        {
            Console.WriteLine("Behaviour patterns:");
            Console.WriteLine(" + Command - 1;");
            Console.WriteLine();
        }
    }
}
