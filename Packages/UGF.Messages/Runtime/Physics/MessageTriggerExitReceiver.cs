using UnityEngine;

namespace UGF.Messages.Runtime.Physics
{
    [AddComponentMenu("Unity Game Framework/Messages/Physics/Message Trigger Exit", 2000)]
    public class MessageTriggerExitReceiver : MonoBehaviour
    {
        [SerializeField] private MessageTrigger m_onExit = new MessageTrigger();

        public MessageTrigger OnExit { get { return m_onExit; } }

        private void OnTriggerExit(Collider other)
        {
            m_onExit.Invoke(other);
        }
    }
}
