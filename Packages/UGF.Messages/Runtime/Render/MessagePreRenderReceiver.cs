using UnityEngine;

namespace UGF.Messages.Runtime.Render
{
    [AddComponentMenu("Unity Game Framework/Messages/Render/Message Pre-Render", 2000)]
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
