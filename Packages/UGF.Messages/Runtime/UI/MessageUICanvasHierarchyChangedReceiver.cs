using UnityEngine;

namespace UGF.Messages.Runtime.UI
{
    public class MessageUICanvasHierarchyChangedReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onHierarchyChanged = new Message();

        public Message OnHierarchyChanged { get { return m_onHierarchyChanged; } }

        private void OnCanvasHierarchyChanged()
        {
            m_onHierarchyChanged.Invoke();
        }
    }
}
