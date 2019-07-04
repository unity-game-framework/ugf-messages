namespace UGF.Messages.Runtime.Audio
{
    public interface IMessageAudioFilterRead : IMessage
    {
        event MessageAudioFilterReadHandler FilterReadInvoked;
    }
}
