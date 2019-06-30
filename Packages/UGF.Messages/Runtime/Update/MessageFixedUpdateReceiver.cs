using UnityEngine;

namespace UGF.Messages.Runtime.Update
{
    public class MessageFixedUpdateReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onFixedUpdate = new Message();

        public Message OnFixedUpdate { get { return m_onFixedUpdate; } }

        private void FixedUpdate()
        {
            m_onFixedUpdate.Invoke();
        }
    }
}
