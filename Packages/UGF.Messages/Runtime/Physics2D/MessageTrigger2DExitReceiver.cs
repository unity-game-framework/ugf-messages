using UnityEngine;

namespace UGF.Messages.Runtime.Physics2D
{
    [AddComponentMenu("Unity Game Framework/Messages/Physics2D/Message Trigger 2D Exit", 2000)]
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
