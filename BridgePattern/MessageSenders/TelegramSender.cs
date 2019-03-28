using System;
using BridgePattern.MessageSenders.Contract;

namespace BridgePattern.MessageSenders
{
    public class TelegramSender : IMessageSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending message with Telegram API ... : {message}");
        }
    }
}