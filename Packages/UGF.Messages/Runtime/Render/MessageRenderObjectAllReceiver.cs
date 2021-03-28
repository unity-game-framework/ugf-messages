using UnityEngine;

namespace UGF.Messages.Runtime.Render
{
    [AddComponentMenu("Unity Game Framework/Messages/Render/Message Render Object All", 2000)]
    public class MessageRenderObjectAllReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onWillRender = new Message();
        [SerializeField] private Message m_onRender = new Message();

        public Message OnWillRender { get { return m_onWillRender; } }
        public Message OnRender { get { return m_onRender; } }

        private void OnWillRenderObject()
        {
            m_onWillRender.Invoke();
        }

        private void OnRenderObject()
        {
            m_onRender.Invoke();
        }
    }
}
