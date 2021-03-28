using UnityEngine;

namespace UGF.Messages.Runtime.Render
{
    [RequireComponent(typeof(Renderer))]
    [AddComponentMenu("Unity Game Framework/Messages/Render/Message Became Visible All", 2000)]
    public class MessageBecameVisibleAllReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onBecameVisible = new Message();
        [SerializeField] private Message m_onBecameInvisible = new Message();

        public Message OnBecameVisibleMessage { get { return m_onBecameVisible; } }
        public Message OnBecameInvisibleMessage { get { return m_onBecameInvisible; } }

        private void OnBecameVisible()
        {
            m_onBecameVisible.Invoke();
        }

        private void OnBecameInvisible()
        {
            m_onBecameInvisible.Invoke();
        }
    }
}
