using UnityEngine;

namespace UGF.Messages.Runtime.Application
{
    [AddComponentMenu("Unity Game Framework/Messages/Application/Message Application Quit", 2000)]
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
