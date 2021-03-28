using UnityEngine;

namespace UGF.Messages.Runtime.Transform
{
    [AddComponentMenu("Unity Game Framework/Messages/Transform/Message Transform Before Parent Changed", 2000)]
    public class MessageTransformBeforeParentChangedReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onBeforeParentChanged = new Message();

        public Message OnBeforeParentChanged { get { return m_onBeforeParentChanged; } }

        private void OnBeforeTransformParentChanged()
        {
            m_onBeforeParentChanged.Invoke();
        }
    }
}
