using UnityEngine;

namespace UGF.Messages.Runtime.Initialization
{
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
