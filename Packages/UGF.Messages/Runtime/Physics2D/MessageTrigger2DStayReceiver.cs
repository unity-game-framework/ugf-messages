using UnityEngine;

namespace UGF.Messages.Runtime.Physics2D
{
    public class MessageTrigger2DStayReceiver : MonoBehaviour
    {
        [SerializeField] private MessageTrigger2D m_stay = new MessageTrigger2D();

        public MessageTrigger2D Stay { get { return m_stay; } }

        private void OnTriggerStay2D(Collider2D other)
        {
            m_stay.Invoke(other);
        }
    }
}
