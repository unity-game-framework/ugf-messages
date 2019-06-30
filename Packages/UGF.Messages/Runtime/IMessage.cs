namespace UGF.Messages.Runtime
{
    public interface IMessage
    {
        event MessageHandler Invoked;
    }
}
