using UnityEngine;

namespace UGF.Messages.Runtime.Initialization
{
    [AddComponentMenu("Unity Game Framework/Messages/Initialization/Message Destroy", 2000)]
    public class MessageDestroyReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onDestroy = new Message();

        public Message OnDestroyMessage { get { return m_onDestroy; } }

        private void OnDestroy()
        {
            m_onDestroy.Invoke();
        }
    }
}
