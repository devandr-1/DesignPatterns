using System;

namespace DesignPatterns.Behavioral.Command
{
    public class ComplexCommand : ICommand
    {
        private Receiver _receiver;

        private string _a, _b;

        public ComplexCommand(Receiver receiver, string a, string b)
        {
            _receiver = receiver;
            _a = a;
            _b = b;
        }

        public void Execute()
        {
            Console.WriteLine("ComplexCommand: working with Receiver.");
            _receiver.DoSomething(_a);
            _receiver.DoSomethingElse(_b);
        }
    }
}
