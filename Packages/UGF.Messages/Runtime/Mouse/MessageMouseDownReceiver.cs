using UnityEngine;

namespace UGF.Messages.Runtime.Mouse
{
    public class MessageMouseDownReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onDown = new Message();

        public Message OnDown { get { return m_onDown; } }

        private void OnMouseDown()
        {
            m_onDown.Invoke();
        }
    }
}
