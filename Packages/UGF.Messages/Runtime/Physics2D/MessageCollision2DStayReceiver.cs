using UnityEngine;

namespace UGF.Messages.Runtime.Physics2D
{
    public class MessageCollision2DStayReceiver : MonoBehaviour
    {
        [SerializeField] private MessageCollision2D m_onStay = new MessageCollision2D();

        public MessageCollision2D OnStay { get { return m_onStay; } }

        private void OnCollisionStay2D(Collision2D other)
        {
            m_onStay.Invoke(other);
        }
    }
}
