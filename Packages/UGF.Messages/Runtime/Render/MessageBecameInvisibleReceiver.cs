using UnityEngine;

namespace UGF.Messages.Runtime.Render
{
    public class MessageBecameInvisibleReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onBecameInvisible = new Message();

        public Message OnBecameInvisibleMessage { get { return m_onBecameInvisible; } }

        private void OnBecameInvisible()
        {
            m_onBecameInvisible.Invoke();
        }
    }
}
