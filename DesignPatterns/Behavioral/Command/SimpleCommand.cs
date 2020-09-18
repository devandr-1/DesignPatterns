using System;

namespace DesignPatterns.Behavioral.Command
{
    public class SimpleCommand : ICommand
    {
        private string _payload = string.Empty;

        public SimpleCommand(string payload)
        {
            _payload = payload;
        }

        public void Execute()
        {
            Console.WriteLine($"SimpleCommand: working on {_payload}.");
        }
    }
}
