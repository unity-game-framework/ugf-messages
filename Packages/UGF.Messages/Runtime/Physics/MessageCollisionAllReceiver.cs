using UnityEngine;

namespace UGF.Messages.Runtime.Physics
{
    [AddComponentMenu("Unity Game Framework/Messages/Physics/Message Collision All", 2000)]
    public class MessageCollisionAllReceiver : MonoBehaviour
    {
        [SerializeField] private MessageCollision m_onEnter = new MessageCollision();
        [SerializeField] private MessageCollision m_onExit = new MessageCollision();
        [SerializeField] private MessageCollision m_onStay = new MessageCollision();

        public MessageCollision OnEnter { get { return m_onEnter; } }
        public MessageCollision OnExit { get { return m_onExit; } }
        public MessageCollision OnStay { get { return m_onStay; } }

        private void OnCollisionEnter(Collision other)
        {
            m_onEnter.Invoke(other);
        }

        private void OnCollisionExit(Collision other)
        {
            m_onExit.Invoke(other);
        }

        private void OnCollisionStay(Collision other)
        {
            m_onStay.Invoke(other);
        }
    }
}
