using UnityEngine;

namespace UGF.Messages.Runtime.Physics
{
    public class MessageCollisionStayReceiver : MonoBehaviour
    {
        [SerializeField] private MessageCollision m_onStay = new MessageCollision();

        public MessageCollision OnStay { get { return m_onStay; } }

        private void OnCollisionStay(Collision other)
        {
            m_onStay.Invoke(other);
        }
    }
}
