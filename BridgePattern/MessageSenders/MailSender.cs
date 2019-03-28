using System;
using BridgePattern.MessageSenders.Contract;

namespace BridgePattern.MessageSenders
{
    public class MailSender : IMessageSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending email ... : {message}");
        }
    }
}