using UnityEngine;

namespace UGF.Messages.Runtime.Application
{
    [AddComponentMenu("Unity Game Framework/Messages/Application/Message Application Focus", 2000)]
    public class MessageApplicationFocusReceiver : MonoBehaviour
    {
        [SerializeField] private MessageApplicationState m_onFocus = new MessageApplicationState();

        public MessageApplicationState OnFocus { get { return m_onFocus; } }

        private void OnApplicationFocus(bool hasFocus)
        {
            m_onFocus.Invoke(hasFocus);
        }
    }
}
