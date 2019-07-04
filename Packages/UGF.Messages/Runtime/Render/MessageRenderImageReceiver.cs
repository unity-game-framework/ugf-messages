using UnityEngine;

namespace UGF.Messages.Runtime.Render
{
    public class MessageRenderImageReceiver : MonoBehaviour
    {
        [SerializeField] private MessageRenderImage m_onRenderImage = new MessageRenderImage();

        public MessageRenderImage OnRenderImageMessage { get { return m_onRenderImage; } }

        private void OnRenderImage(RenderTexture src, RenderTexture dest)
        {
            m_onRenderImage.Invoke(src, dest);
        }
    }
}
