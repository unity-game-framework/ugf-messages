using UnityEngine;

namespace UGF.Messages.Runtime.Physics
{
    [AddComponentMenu("Unity Game Framework/Messages/Physics/Message Trigger All", 2000)]
    public class MessageTriggerAllReceiver : MonoBehaviour
    {
        [SerializeField] private MessageTrigger m_onEnter = new MessageTrigger();
        [SerializeField] private MessageTrigger m_onExit = new MessageTrigger();
        [SerializeField] private MessageTrigger m_onStay = new MessageTrigger();

        public MessageTrigger OnEnter { get { return m_onEnter; } }
        public MessageTrigger OnExit { get { return m_onExit; } }
        public MessageTrigger OnStay { get { return m_onStay; } }

        private void OnTriggerEnter(Collider other)
        {
            m_onEnter.Invoke(other);
        }

        private void OnTriggerExit(Collider other)
        {
            m_onExit.Invoke(other);
        }

        private void OnTriggerStay(Collider other)
        {
            m_onStay.Invoke(other);
        }
    }
}
