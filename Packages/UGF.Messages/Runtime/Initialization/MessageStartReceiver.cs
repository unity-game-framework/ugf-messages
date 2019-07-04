using UnityEngine;

namespace UGF.Messages.Runtime.Initialization
{
    public class MessageStartReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onStart = new Message();

        public Message OnStart { get { return m_onStart; } }

        private void Start()
        {
            m_onStart.Invoke();
        }
    }
}
