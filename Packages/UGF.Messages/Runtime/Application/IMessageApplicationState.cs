namespace UGF.Messages.Runtime.Application
{
    public interface IMessageApplicationState : IMessage
    {
        event MessageApplicationStateHandler StateInvoked;
    }
}
