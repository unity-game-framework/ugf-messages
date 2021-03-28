using UnityEngine;

namespace UGF.Messages.Runtime.Update
{
    [AddComponentMenu("Unity Game Framework/Messages/Update/Message Update", 2000)]
    public class MessageUpdateReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onUpdate = new Message();

        public Message OnUpdate { get { return m_onUpdate; } }

        private void Update()
        {
            m_onUpdate.Invoke();
        }
    }
}
