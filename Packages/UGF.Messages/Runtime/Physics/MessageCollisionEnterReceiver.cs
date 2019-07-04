using UnityEngine;

namespace UGF.Messages.Runtime.Physics
{
    public class MessageCollisionEnterReceiver : MonoBehaviour
    {
        [SerializeField] private MessageCollision m_onEnter = new MessageCollision();

        public MessageCollision OnEnter { get { return m_onEnter; } }

        private void OnCollisionEnter(Collision other)
        {
            m_onEnter.Invoke(other);
        }
    }
}
