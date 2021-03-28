using UnityEngine;

namespace UGF.Messages.Runtime.Audio
{
    [AddComponentMenu("Unity Game Framework/Messages/Audio/Message Audio Filter Read", 2000)]
    public class MessageAudioFilterReadReceiver : MonoBehaviour
    {
        [SerializeField] private MessageAudioFilterRead m_onFilterRead = new MessageAudioFilterRead();

        public MessageAudioFilterRead OnFilterRead { get { return m_onFilterRead; } }

        private void OnAudioFilterRead(float[] data, int channels)
        {
            m_onFilterRead.Invoke(data, channels);
        }
    }
}
