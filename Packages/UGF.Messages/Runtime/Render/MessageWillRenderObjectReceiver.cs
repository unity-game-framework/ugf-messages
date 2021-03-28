using UnityEngine;

namespace UGF.Messages.Runtime.Render
{
    [AddComponentMenu("Unity Game Framework/Messages/Render/Message Will Render Object", 2000)]
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
