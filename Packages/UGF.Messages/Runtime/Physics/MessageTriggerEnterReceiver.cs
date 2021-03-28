using UnityEngine;

namespace UGF.Messages.Runtime.Physics
{
    [AddComponentMenu("Unity Game Framework/Messages/Physics/Message Trigger Enter", 2000)]
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
