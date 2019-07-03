using UnityEngine;

namespace UGF.Messages.Runtime.Transform
{
    public class MessageTransformChildrenChangedReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_childrenChanged = new Message();

        public Message ChildrenChanged { get { return m_childrenChanged; } }

        private void OnTransformChildrenChanged()
        {
            m_childrenChanged.Invoke();
        }
    }
}
