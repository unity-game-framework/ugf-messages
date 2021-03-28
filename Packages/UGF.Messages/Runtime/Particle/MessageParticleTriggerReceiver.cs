using UnityEngine;

namespace UGF.Messages.Runtime.Particle
{
#if UGF_HAS_MODULE_PARTICLESYSTEM
    [RequireComponent(typeof(ParticleSystem))]
#endif
    [AddComponentMenu("Unity Game Framework/Messages/Particle/Message Particle Trigger", 2000)]
    public class MessageParticleTriggerReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onTrigger = new Message();

        public Message OnTrigger { get { return m_onTrigger;  } }

        private void OnParticleTrigger()
        {
            m_onTrigger.Invoke();
        }
    }
}
