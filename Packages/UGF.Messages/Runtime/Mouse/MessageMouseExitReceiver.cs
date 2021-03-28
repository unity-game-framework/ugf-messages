using UnityEngine;

namespace UGF.Messages.Runtime.Mouse
{
    [AddComponentMenu("Unity Game Framework/Messages/Mouse/Message Mouse Exit", 2000)]
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
