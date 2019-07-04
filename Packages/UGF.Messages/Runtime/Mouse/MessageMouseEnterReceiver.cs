using UnityEngine;

namespace UGF.Messages.Runtime.Mouse
{
    public class MessageMouseEnterReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onEnter = new Message();

        public Message OnEnter { get { return m_onEnter; } }

        private void OnMouseEnter()
        {
            m_onEnter.Invoke();
        }
    }
}
