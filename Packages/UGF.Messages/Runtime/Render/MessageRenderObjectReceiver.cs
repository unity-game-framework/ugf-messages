using UnityEngine;

namespace UGF.Messages.Runtime.Render
{
    public class MessageRenderObjectReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onRender = new Message();

        public Message OnRender { get { return m_onRender; } }

        private void OnRenderObject()
        {
            m_onRender.Invoke();
        }
    }
}
