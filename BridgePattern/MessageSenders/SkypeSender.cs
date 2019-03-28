using System;
using BridgePattern.MessageSenders.Contract;

namespace BridgePattern.MessageSenders
{
    public class SkypeSender : IMessageSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending message with Skype API ... : {message}");
        }
    }
}