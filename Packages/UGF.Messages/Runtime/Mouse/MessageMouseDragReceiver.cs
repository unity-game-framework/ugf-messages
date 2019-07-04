using UnityEngine;

namespace UGF.Messages.Runtime.Mouse
{
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
