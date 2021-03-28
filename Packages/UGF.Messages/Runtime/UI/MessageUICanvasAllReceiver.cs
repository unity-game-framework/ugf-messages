using UnityEngine;

namespace UGF.Messages.Runtime.UI
{
    [AddComponentMenu("Unity Game Framework/Messages/UI/Message UI Canvas All", 2000)]
    public class MessageUICanvasAllReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onGroupChanged = new Message();
        [SerializeField] private Message m_onHierarchyChanged = new Message();

        public Message OnGroupChanged { get { return m_onGroupChanged; } }
        public Message OnHierarchyChanged { get { return m_onHierarchyChanged; } }

        private void OnCanvasGroupChanged()
        {
            m_onGroupChanged.Invoke();
        }

        private void OnCanvasHierarchyChanged()
        {
            m_onHierarchyChanged.Invoke();
        }
    }
}
