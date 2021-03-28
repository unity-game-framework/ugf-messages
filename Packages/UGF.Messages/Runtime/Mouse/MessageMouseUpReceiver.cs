using UnityEngine;

namespace UGF.Messages.Runtime.Mouse
{
    [AddComponentMenu("Unity Game Framework/Messages/Mouse/Message Mouse Up", 2000)]
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
