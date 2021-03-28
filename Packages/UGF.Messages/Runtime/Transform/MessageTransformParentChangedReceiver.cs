using UnityEngine;

namespace UGF.Messages.Runtime.Transform
{
    [AddComponentMenu("Unity Game Framework/Messages/Transform/Message Transform Parent Changed", 2000)]
    public class MessageTransformParentChangedReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onParentChanged = new Message();

        public Message OnParentChanged { get { return m_onParentChanged; } }

        private void OnTransformParentChanged()
        {
            m_onParentChanged.Invoke();
        }
    }
}
