using UnityEngine;

namespace UGF.Messages.Runtime.Render
{
    [AddComponentMenu("Unity Game Framework/Messages/Render/Message Render Object", 2000)]
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
