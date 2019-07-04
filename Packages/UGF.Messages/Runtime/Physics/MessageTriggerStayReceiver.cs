using UnityEngine;

namespace UGF.Messages.Runtime.Physics
{
    public class MessageTriggerStayReceiver : MonoBehaviour
    {
        [SerializeField] private MessageTrigger m_onStay = new MessageTrigger();

        public MessageTrigger OnStay { get { return m_onStay; } }

        private void OnTriggerStay(Collider other)
        {
            m_onStay.Invoke(other);
        }
    }
}
