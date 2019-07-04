namespace UGF.Messages.Runtime.Physics
{
    public interface IMessageTrigger : IMessage
    {
        event MessageTriggerHandler TriggerInvoked;
    }
}
