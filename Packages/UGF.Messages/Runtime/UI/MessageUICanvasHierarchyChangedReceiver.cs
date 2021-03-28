using UnityEngine;

namespace UGF.Messages.Runtime.UI
{
    [AddComponentMenu("Unity Game Framework/Messages/UI/Message UI Canvas Hierarchy Changed", 2000)]
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
