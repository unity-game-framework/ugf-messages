using UnityEngine;

namespace UGF.Messages.Runtime.Render
{
    [RequireComponent(typeof(Camera))]
    [AddComponentMenu("Unity Game Framework/Messages/Render/Message Pre-Cull", 2000)]
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
