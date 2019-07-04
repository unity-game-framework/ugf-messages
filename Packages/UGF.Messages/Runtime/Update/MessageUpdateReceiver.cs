using UnityEngine;

namespace UGF.Messages.Runtime.Update
{
    public class MessageUpdateReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onUpdate = new Message();

        public Message OnUpdate { get { return m_onUpdate; } }

        private void Update()
        {
            m_onUpdate.Invoke();
        }
    }
}
