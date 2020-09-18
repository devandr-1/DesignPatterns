using System;

namespace DesignPatterns.Behavioral.Command
{
    public class Receiver
    {
        public void DoSomething(string a)
        {
            Console.WriteLine($"Receiver: working on {a}.");
        }

        public void DoSomethingElse(string b)
        {
            Console.WriteLine($"Receiver: also working on {b}.");
        }
    }
}
