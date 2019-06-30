using UnityEngine;

namespace UGF.Messages.Runtime.Update
{
    public class MessageLateUpdateReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onLateUpdate = new Message();

        public Message OnLateUpdate { get { return m_onLateUpdate; } }

        private void LateUpdate()
        {
            m_onLateUpdate.Invoke();
        }
    }
}
