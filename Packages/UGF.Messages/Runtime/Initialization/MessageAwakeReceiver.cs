using UnityEngine;

namespace UGF.Messages.Runtime.Initialization
{
    [AddComponentMenu("Unity Game Framework/Messages/Initialization/Message Awake", 2000)]
    public class MessageAwakeReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onAwake = new Message();

        public Message OnAwake { get { return m_onAwake; } }

        private void Awake()
        {
            m_onAwake.Invoke();
        }
    }
}
