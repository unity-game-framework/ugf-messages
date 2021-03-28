using UnityEngine;

namespace UGF.Messages.Runtime.Mouse
{
    [AddComponentMenu("Unity Game Framework/Messages/Mouse/Message Mouse Drag", 2000)]
    public class MessageMouseDragReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onDrag = new Message();

        public Message OnDrag { get { return m_onDrag; } }

        private void OnMouseDrag()
        {
            m_onDrag.Invoke();
        }
    }
}
