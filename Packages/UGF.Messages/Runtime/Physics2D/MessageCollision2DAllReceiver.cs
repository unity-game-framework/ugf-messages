using UnityEngine;

namespace UGF.Messages.Runtime.Physics2D
{
    [AddComponentMenu("Unity Game Framework/Messages/Physics2D/Message Collision 2D All", 2000)]
    public class MessageCollision2DAllReceiver : MonoBehaviour
    {
        [SerializeField] private MessageCollision2D m_onEnter = new MessageCollision2D();
        [SerializeField] private MessageCollision2D m_onExit = new MessageCollision2D();
        [SerializeField] private MessageCollision2D m_onStay = new MessageCollision2D();

        public MessageCollision2D OnEnter { get { return m_onEnter; } }
        public MessageCollision2D OnExit { get { return m_onExit; } }
        public MessageCollision2D OnStay { get { return m_onStay; } }

        private void OnCollisionEnter2D(Collision2D other)
        {
            m_onEnter.Invoke(other);
        }

        private void OnCollisionExit2D(Collision2D other)
        {
            m_onExit.Invoke(other);
        }

        private void OnCollisionStay2D(Collision2D other)
        {
            m_onStay.Invoke(other);
        }
    }
}
