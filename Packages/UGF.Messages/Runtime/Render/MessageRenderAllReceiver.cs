using UnityEngine;

namespace UGF.Messages.Runtime.Render
{
    [AddComponentMenu("Unity Game Framework/Messages/Render/Message Render All", 2000)]
    public class MessageRenderAllReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onPreCull = new Message();
        [SerializeField] private Message m_onPreRender = new Message();
        [SerializeField] private Message m_onPostRender = new Message();
        [SerializeField] private MessageRenderImage m_onRenderImage = new MessageRenderImage();

        public Message OnPreCullMessage { get { return m_onPreCull; } }
        public Message OnPreRenderMessage { get { return m_onPreRender; } }
        public Message OnPostRenderMessage { get { return m_onPostRender; } }
        public MessageRenderImage OnRenderImageMessage { get { return m_onRenderImage; } }

        private void OnPreCull()
        {
            m_onPreCull.Invoke();
        }

        private void OnPreRender()
        {
            m_onPreRender.Invoke();
        }

        private void OnPostRender()
        {
            m_onPostRender.Invoke();
        }

        private void OnRenderImage(RenderTexture src, RenderTexture dest)
        {
            m_onRenderImage.Invoke(src, dest);
        }
    }
}
