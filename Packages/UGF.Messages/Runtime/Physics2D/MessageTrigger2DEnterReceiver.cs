using UnityEngine;

namespace UGF.Messages.Runtime.Physics2D
{
    [AddComponentMenu("Unity Game Framework/Messages/Physics2D/Message Trigger 2D Enter", 2000)]
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
