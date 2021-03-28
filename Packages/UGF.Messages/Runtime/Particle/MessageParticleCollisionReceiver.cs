using UnityEngine;

namespace UGF.Messages.Runtime.Particle
{
    [AddComponentMenu("Unity Game Framework/Messages/Particle/Message Particle Collision", 2000)]
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
