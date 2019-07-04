using UnityEngine;

namespace UGF.Messages.Runtime.Physics2D
{
    public class MessageCollision2DEnterReceiver : MonoBehaviour
    {
        [SerializeField] private MessageCollision2D m_onEnter = new MessageCollision2D();

        public MessageCollision2D OnEnter { get { return m_onEnter; } }

        private void OnCollisionEnter2D(Collision2D other)
        {
            m_onEnter.Invoke(other);
        }
    }
}
