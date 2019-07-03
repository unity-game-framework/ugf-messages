using UnityEngine;

namespace UGF.Messages.Runtime.Render
{
    public class MessageWillRenderObjectReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onWillRender = new Message();

        public Message OnWillRender { get { return m_onWillRender; } }

        private void OnWillRenderObject()
        {
            m_onWillRender.Invoke();
        }
    }
}
