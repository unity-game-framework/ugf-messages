using UnityEngine;

namespace UGF.Messages.Runtime.Application
{
    [AddComponentMenu("Unity Game Framework/Messages/Application/Message Application All", 2000)]
    public class MessageApplicationAllReceiver : MonoBehaviour
    {
        [SerializeField] private MessageApplicationState m_onFocus = new MessageApplicationState();
        [SerializeField] private MessageApplicationState m_onPause = new MessageApplicationState();
        [SerializeField] private Message m_onQuit = new Message();

        public MessageApplicationState OnFocus { get { return m_onFocus; } }
        public MessageApplicationState OnPause { get { return m_onPause; } }
        public Message OnQuit { get { return m_onQuit; } }

        private void OnApplicationFocus(bool hasFocus)
        {
            m_onFocus.Invoke(hasFocus);
        }

        private void OnApplicationPause(bool pauseStatus)
        {
            m_onPause.Invoke(pauseStatus);
        }

        private void OnApplicationQuit()
        {
            m_onQuit.Invoke();
        }
    }
}
