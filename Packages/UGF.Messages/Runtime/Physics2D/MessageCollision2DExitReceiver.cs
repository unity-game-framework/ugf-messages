using UnityEngine;

namespace UGF.Messages.Runtime.Physics2D
{
    public class MessageCollision2DExitReceiver : MonoBehaviour
    {
        [SerializeField] private MessageCollision2D m_onExit = new MessageCollision2D();

        public MessageCollision2D OnExit { get { return m_onExit; } }

        private void OnCollisionExit2D(Collision2D other)
        {
            m_onExit.Invoke(other);
        }
    }
}
