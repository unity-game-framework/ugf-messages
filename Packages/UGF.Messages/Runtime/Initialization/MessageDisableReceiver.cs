using UnityEngine;

namespace UGF.Messages.Runtime.Initialization
{
    [AddComponentMenu("Unity Game Framework/Messages/Initialization/Message Disable", 2000)]
    public class MessageDisableReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onDisable = new Message();

        public Message OnDisableMessage { get { return m_onDisable; } }

        private void OnDisable()
        {
            m_onDisable.Invoke();
        }
    }
}
