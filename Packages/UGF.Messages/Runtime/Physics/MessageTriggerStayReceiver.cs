using UnityEngine;

namespace UGF.Messages.Runtime.Physics
{
    [AddComponentMenu("Unity Game Framework/Messages/Physics/Message Trigger Stay", 2000)]
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
