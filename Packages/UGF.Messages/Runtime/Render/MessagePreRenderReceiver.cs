using UnityEngine;

namespace UGF.Messages.Runtime.Render
{
    public class MessagePreRenderReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onPreRender = new Message();

        public Message OnPreRenderMessage { get { return m_onPreRender; } }

        private void OnPreRender()
        {
            m_onPreRender.Invoke();
        }
    }
}
