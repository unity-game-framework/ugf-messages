using UnityEngine;

namespace UGF.Messages.Runtime.Render
{
    public class MessageBecameVisibleReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onBecameVisible = new Message();

        public Message OnBecameVisibleMessage { get { return m_onBecameVisible; } }

        private void OnBecameVisible()
        {
            m_onBecameVisible.Invoke();
        }
    }
}
