namespace UGF.Messages.Runtime.Physics2D
{
    public interface IMessageTrigger2D : IMessage
    {
        event MessageTrigger2DHandler TriggerInvoked;
    }
}
