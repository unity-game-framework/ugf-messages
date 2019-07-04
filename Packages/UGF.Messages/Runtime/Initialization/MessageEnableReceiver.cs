using UnityEngine;

namespace UGF.Messages.Runtime.Initialization
{
    public class MessageEnableReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onEnable = new Message();

        public Message OnEnableMessage { get { return m_onEnable; } }

        private void OnEnable()
        {
            m_onEnable.Invoke();
        }
    }
}
