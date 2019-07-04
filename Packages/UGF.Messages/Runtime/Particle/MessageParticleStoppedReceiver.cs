using UnityEngine;

namespace UGF.Messages.Runtime.Particle
{
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
