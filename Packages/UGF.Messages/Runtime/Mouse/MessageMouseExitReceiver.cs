using UnityEngine;

namespace UGF.Messages.Runtime.Mouse
{
    public class MessageMouseExitReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onExit = new Message();

        public Message OnExit { get { return m_onExit; } }

        private void OnMouseExit()
        {
            m_onExit.Invoke();
        }
    }
}
