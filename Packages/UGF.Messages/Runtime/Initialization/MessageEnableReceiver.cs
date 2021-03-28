using UnityEngine;

namespace UGF.Messages.Runtime.Initialization
{
    [AddComponentMenu("Unity Game Framework/Messages/Initialization/Message Enable", 2000)]
    public class MessageEnableReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onEnable = new Message();

        public Message OnEnableMessage { get { return m_onEnable; } }

        private void OnEnable()
        {
            m_onEnable.Invoke();
        }
    }
}
