using UnityEngine;

namespace UGF.Messages.Runtime.Physics2D
{
    [AddComponentMenu("Unity Game Framework/Messages/Physics2D/Message Trigger 2D All", 2000)]
    public class MessageTrigger2DAllReceiver : MonoBehaviour
    {
        [SerializeField] private MessageTrigger2D m_onEnter = new MessageTrigger2D();
        [SerializeField] private MessageTrigger2D m_onExit = new MessageTrigger2D();
        [SerializeField] private MessageTrigger2D m_onStay = new MessageTrigger2D();

        public MessageTrigger2D OnEnter { get { return m_onEnter; } }
        public MessageTrigger2D OnExit { get { return m_onExit; } }
        public MessageTrigger2D OnStay { get { return m_onStay; } }

        private void OnTriggerEnter2D(Collider2D other)
        {
            m_onEnter.Invoke(other);
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            m_onExit.Invoke(other);
        }

        private void OnTriggerStay2D(Collider2D other)
        {
            m_onStay.Invoke(other);
        }
    }
}
