using UnityEngine;

namespace UGF.Messages.Runtime.Application
{
    public class MessageApplicationQuitReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onQuit = new Message();

        public Message OnQuit { get { return m_onQuit; } }

        private void OnApplicationQuit()
        {
            m_onQuit.Invoke();
        }
    }
}
