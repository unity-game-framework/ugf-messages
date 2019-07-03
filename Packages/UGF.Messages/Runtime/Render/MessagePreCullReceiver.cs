using UnityEngine;

namespace UGF.Messages.Runtime.Render
{
    public class MessagePreCullReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onPreCull = new Message();

        public Message OnPreCullMessage { get { return m_onPreCull; } }

        private void OnPreCull()
        {
            m_onPreCull.Invoke();
        }
    }
}
