using UnityEngine;

namespace UGF.Messages.Runtime.Physics
{
    [AddComponentMenu("Unity Game Framework/Messages/Physics/Message Collision Stay", 2000)]
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
