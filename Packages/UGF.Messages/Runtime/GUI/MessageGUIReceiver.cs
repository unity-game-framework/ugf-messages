using UnityEngine;

namespace UGF.Messages.Runtime.GUI
{
    [AddComponentMenu("Unity Game Framework/Messages/GUI/Message GUI", 2000)]
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
