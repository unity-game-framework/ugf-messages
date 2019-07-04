using UnityEngine;

namespace UGF.Messages.Runtime.Physics
{
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
