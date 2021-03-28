using UnityEngine;

namespace UGF.Messages.Runtime.UI
{
    [AddComponentMenu("Unity Game Framework/Messages/UI/Message UI Canvas Group Changed", 2000)]
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
