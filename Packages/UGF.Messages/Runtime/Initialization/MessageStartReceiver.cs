using UnityEngine;

namespace UGF.Messages.Runtime.Initialization
{
    [AddComponentMenu("Unity Game Framework/Messages/Initialization/Message Start", 2000)]
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
