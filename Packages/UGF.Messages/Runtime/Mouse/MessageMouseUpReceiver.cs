using UnityEngine;

namespace UGF.Messages.Runtime.Mouse
{
    public class MessageMouseUpReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onUp = new Message();

        public Message OnUp { get { return m_onUp; } }

        private void OnMouseUp()
        {
            m_onUp.Invoke();
        }
    }
}
