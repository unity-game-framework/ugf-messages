using UnityEngine;

namespace UGF.Messages.Runtime.Application
{
    [AddComponentMenu("Unity Game Framework/Messages/Application/Message Application Pause", 2000)]
    public class MessageApplicationPauseReceiver : MonoBehaviour
    {
        [SerializeField] private MessageApplicationState m_onPause = new MessageApplicationState();

        public MessageApplicationState OnPause { get { return m_onPause; } }

        private void OnApplicationPause(bool pauseStatus)
        {
            m_onPause.Invoke(pauseStatus);
        }
    }
}
