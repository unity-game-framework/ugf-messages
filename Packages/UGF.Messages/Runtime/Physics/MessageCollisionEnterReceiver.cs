using UnityEngine;

namespace UGF.Messages.Runtime.Physics
{
    [AddComponentMenu("Unity Game Framework/Messages/Physics/Message Collision Enter", 2000)]
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
