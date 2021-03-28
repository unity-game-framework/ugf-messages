using UnityEngine;

namespace UGF.Messages.Runtime.Mouse
{
    [AddComponentMenu("Unity Game Framework/Messages/Mouse/Message Mouse Up As Button", 2000)]
    public class MessageMouseUpAsButtonReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onUpAsButton = new Message();

        public Message OnUpAsButton { get { return m_onUpAsButton; } }

        private void OnMouseUpAsButton()
        {
            m_onUpAsButton.Invoke();
        }
    }
}
