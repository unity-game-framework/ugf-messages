using UnityEngine;

namespace UGF.Messages.Runtime.GUI
{
    public class MessageGUIReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onGUI = new Message();

        public Message OnGUIMessage { get { return m_onGUI; } }

        private void OnGUI()
        {
            m_onGUI.Invoke();
        }
    }
}
