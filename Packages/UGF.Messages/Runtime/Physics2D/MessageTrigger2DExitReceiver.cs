using UnityEngine;

namespace UGF.Messages.Runtime.Physics2D
{
    public class MessageTrigger2DExitReceiver : MonoBehaviour
    {
        [SerializeField] private MessageTrigger2D m_onExit = new MessageTrigger2D();

        public MessageTrigger2D OnExit { get { return m_onExit; } }

        private void OnTriggerExit2D(Collider2D other)
        {
            m_onExit.Invoke(other);
        }
    }
}
