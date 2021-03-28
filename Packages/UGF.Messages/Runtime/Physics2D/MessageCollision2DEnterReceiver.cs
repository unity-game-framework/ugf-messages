using UnityEngine;

namespace UGF.Messages.Runtime.Physics2D
{
    [AddComponentMenu("Unity Game Framework/Messages/Physics2D/Message Collision 2D Enter", 2000)]
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
