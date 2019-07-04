using UnityEngine;

namespace UGF.Messages.Runtime.Application
{
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
