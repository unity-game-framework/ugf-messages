using UnityEngine;

namespace UGF.Messages.Runtime.Mouse
{
    [AddComponentMenu("Unity Game Framework/Messages/Mouse/Message Mouse Over", 2000)]
    public class MessageMouseOverReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onOver = new Message();

        public Message OnOver { get { return m_onOver; } }

        private void OnMouseOver()
        {
            m_onOver.Invoke();
        }
    }
}
