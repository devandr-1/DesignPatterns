using System;

namespace DesignPatterns.Behavioral.Command
{
    public class Invoker
    {
        private ICommand _onStart, _onFinish;

        public ICommand OnStart
        {
            set => _onStart = value;
        }

        public ICommand OnFinish
        {
            set => _onFinish = value;
        }

        public void DoSomethingImportant()
        {
            Console.WriteLine("Invoker: start");
            _onStart.Execute();

            Console.WriteLine("Invoker: working...");

            Console.WriteLine("Invoker: finish");
            _onFinish.Execute();
        }
    }
}
