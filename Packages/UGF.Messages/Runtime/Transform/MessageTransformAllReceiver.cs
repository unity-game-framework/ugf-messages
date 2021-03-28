using UnityEngine;

namespace UGF.Messages.Runtime.Transform
{
    [AddComponentMenu("Unity Game Framework/Messages/Transform/Message Transform All", 2000)]
    public class MessageTransformAllReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onBeforeParentChanged = new Message();
        [SerializeField] private Message m_onParentChanged = new Message();
        [SerializeField] private Message m_onChildrenChanged = new Message();

        public Message OnBeforeParentChanged { get { return m_onBeforeParentChanged; } }
        public Message OnParentChanged { get { return m_onParentChanged; } }
        public Message OnChildrenChanged { get { return m_onChildrenChanged; } }

        private void OnBeforeTransformParentChanged()
        {
            m_onBeforeParentChanged.Invoke();
        }

        private void OnTransformParentChanged()
        {
            m_onParentChanged.Invoke();
        }

        private void OnTransformChildrenChanged()
        {
            m_onChildrenChanged.Invoke();
        }
    }
}
