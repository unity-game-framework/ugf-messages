using UnityEngine;

namespace UGF.Messages.Runtime.Initialization
{
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
