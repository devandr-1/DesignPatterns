using System;

namespace DesignPatterns.Behavioral.Command
{
    public static class Client
    {
        public static void Run()
        {
            Invoker invoker = new Invoker();
            invoker.OnStart = new SimpleCommand("Some simple command");
            Receiver receiver = new Receiver();
            invoker.OnFinish = new ComplexCommand(receiver, "Command A", "Command B");
            invoker.DoSomethingImportant();
        }
    }
}
