using UnityEngine;

namespace UGF.Messages.Runtime.Particle
{
    public class MessageParticleCollisionReceiver : MonoBehaviour
    {
        [SerializeField] private MessageParticleCollision m_onCollision = new MessageParticleCollision();

        public MessageParticleCollision OnCollision { get { return m_onCollision; } }

        private void OnParticleCollision(GameObject other)
        {
            m_onCollision.Invoke(other);
        }
    }
}
