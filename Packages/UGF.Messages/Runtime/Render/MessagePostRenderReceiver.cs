using UnityEngine;

namespace UGF.Messages.Runtime.Render
{
    [AddComponentMenu("Unity Game Framework/Messages/Render/Message Post Render", 2000)]
    public class MessagePostRenderReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onPostRender = new Message();

        public Message OnPostRenderMessage { get { return m_onPostRender; } }

        private void OnPostRender()
        {
            m_onPostRender.Invoke();
        }
    }
}
