namespace BridgePattern.MessageSenders.Contract
{
    public interface IMessageSender
    {
        void Send(string message);
    }
}