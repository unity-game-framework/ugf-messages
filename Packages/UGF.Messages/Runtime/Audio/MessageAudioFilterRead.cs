namespace UGF.Messages.Runtime.Audio
{
    public class MessageAudioFilterRead : Message, IMessageAudioFilterRead
    {
        public event MessageAudioFilterReadHandler FilterReadInvoked;

        public void Invoke(float[] data, int channels)
        {
            Invoke();

            FilterReadInvoked?.Invoke(data, channels);
        }
    }
}
