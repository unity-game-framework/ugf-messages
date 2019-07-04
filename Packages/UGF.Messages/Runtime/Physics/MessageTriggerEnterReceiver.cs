using UnityEngine;

namespace UGF.Messages.Runtime.Physics
{
    public class MessageTriggerEnterReceiver : MonoBehaviour
    {
        [SerializeField] private MessageTrigger m_onEnter = new MessageTrigger();

        public MessageTrigger OnEnter { get { return m_onEnter; } }

        private void OnTriggerEnter(Collider other)
        {
            m_onEnter.Invoke(other);
        }
    }
}
