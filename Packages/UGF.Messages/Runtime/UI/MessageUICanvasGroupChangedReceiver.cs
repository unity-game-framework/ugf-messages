using UnityEngine;

namespace UGF.Messages.Runtime.UI
{
    public class MessageUICanvasGroupChangedReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onGroupChanged = new Message();

        public Message OnGroupChanged { get { return m_onGroupChanged; } }

        private void OnCanvasGroupChanged()
        {
            m_onGroupChanged.Invoke();
        }
    }
}
