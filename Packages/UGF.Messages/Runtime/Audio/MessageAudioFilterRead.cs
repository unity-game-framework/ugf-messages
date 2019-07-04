using System;

namespace UGF.Messages.Runtime.Audio
{
    [Serializable]
    public class MessageAudioFilterRead : Message, IMessageAudioFilterRead
    {
        public event MessageAudioFilterReadHandler FilterReadInvoked;

        public void Invoke(float[] data, int channels)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));

            Invoke();

            FilterReadInvoked?.Invoke(data, channels);
        }
    }
}
