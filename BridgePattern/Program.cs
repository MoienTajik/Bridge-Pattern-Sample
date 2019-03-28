using System;
using BridgePattern.MessageSenders;

namespace BridgePattern
{
    internal class Program
    {
        private static void Main()
        {
            Notifier notifier = new Notifier(new TelegramSender());
            notifier.Notify("It's 7pm, Go to Gym.");

            notifier.ChangeMessageSender(new MailSender());
            notifier.Notify("Don't forget to complete task #5426 today.");

            notifier.ChangeMessageSender(new SkypeSender());
            notifier.Notify("Don't forget to call John at 5pm.");

            Console.ReadKey();
        }
    }
}