using UnityEngine;

namespace UGF.Messages.Runtime.Particle
{
    [AddComponentMenu("Unity Game Framework/Messages/Particle/Message Particle Stopped", 2000)]
    public class MessageParticleStoppedReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onStopped = new Message();

        public Message OnStopped { get { return m_onStopped; } }

        private void OnParticleSystemStopped()
        {
            m_onStopped.Invoke();
        }
    }
}
