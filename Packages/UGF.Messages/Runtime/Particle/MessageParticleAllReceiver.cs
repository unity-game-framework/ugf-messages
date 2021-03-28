using UnityEngine;

namespace UGF.Messages.Runtime.Particle
{
#if UGF_HAS_MODULE_PARTICLESYSTEM
    [RequireComponent(typeof(ParticleSystem))]
#endif
    [AddComponentMenu("Unity Game Framework/Messages/Particle/Message Particle All", 2000)]
    public class MessageParticleAllReceiver : MonoBehaviour
    {
        [SerializeField] private MessageParticleCollision m_onCollision = new MessageParticleCollision();
        [SerializeField] private Message m_onStopped = new Message();
        [SerializeField] private Message m_onTrigger = new Message();

        public MessageParticleCollision OnCollision { get { return m_onCollision; } }
        public Message OnStopped { get { return m_onStopped; } }
        public Message OnTrigger { get { return m_onTrigger; } }

        private void OnParticleCollision(GameObject other)
        {
            m_onCollision.Invoke(other);
        }

        private void OnParticleSystemStopped()
        {
            m_onStopped.Invoke();
        }

        private void OnParticleTrigger()
        {
            m_onTrigger.Invoke();
        }
    }
}
