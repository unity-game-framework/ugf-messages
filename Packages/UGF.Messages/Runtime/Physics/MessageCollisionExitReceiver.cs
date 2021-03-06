using UnityEngine;

namespace UGF.Messages.Runtime.Physics
{
    [AddComponentMenu("Unity Game Framework/Messages/Physics/Message Collision Exit", 2000)]
    public class MessageCollisionExitReceiver : MonoBehaviour
    {
        [SerializeField] private MessageCollision m_onExit = new MessageCollision();

        public MessageCollision OnExit { get { return m_onExit; } }

        private void OnCollisionExit(Collision other)
        {
            m_onExit.Invoke(other);
        }
    }
}
