using UnityEngine;

namespace UGF.Messages.Runtime.Render
{
    [RequireComponent(typeof(Renderer))]
    [AddComponentMenu("Unity Game Framework/Messages/Render/Message Became Invisible", 2000)]
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
