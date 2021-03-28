using UnityEngine;

namespace UGF.Messages.Runtime.Render
{
    [AddComponentMenu("Unity Game Framework/Messages/Render/Message Render Image", 2000)]
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
