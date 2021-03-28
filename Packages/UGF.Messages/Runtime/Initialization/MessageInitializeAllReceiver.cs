using UnityEngine;

namespace UGF.Messages.Runtime.Initialization
{
    [AddComponentMenu("Unity Game Framework/Messages/Initialization/Message Initialize All", 2000)]
    public class MessageInitializeAllReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onAwake = new Message();
        [SerializeField] private Message m_onStart = new Message();
        [SerializeField] private Message m_onEnable = new Message();
        [SerializeField] private Message m_onDisable = new Message();
        [SerializeField] private Message m_onDestroy = new Message();

        public Message OnAwake { get { return m_onAwake; } }
        public Message OnStart { get { return m_onStart; } }
        public Message OnEnableMessage { get { return m_onEnable; } }
        public Message OnDisableMessage { get { return m_onDisable; } }
        public Message OnDestroyMessage { get { return m_onDestroy; } }

        private void Awake()
        {
            m_onAwake.Invoke();
        }

        private void Start()
        {
            m_onStart.Invoke();
        }

        private void OnDisable()
        {
            m_onDisable.Invoke();
        }

        private void OnEnable()
        {
            m_onEnable.Invoke();
        }

        private void OnDestroy()
        {
            m_onDestroy.Invoke();
        }
    }
}
