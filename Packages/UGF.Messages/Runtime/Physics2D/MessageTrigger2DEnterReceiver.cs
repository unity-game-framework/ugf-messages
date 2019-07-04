using UnityEngine;

namespace UGF.Messages.Runtime.Physics2D
{
    public class MessageTrigger2DEnterReceiver : MonoBehaviour
    {
        [SerializeField] private MessageTrigger2D m_onEnter = new MessageTrigger2D();

        public MessageTrigger2D OnEnter { get { return m_onEnter; } }

        private void OnTriggerEnter2D(Collider2D other)
        {
            m_onEnter.Invoke(other);
        }
    }
}
