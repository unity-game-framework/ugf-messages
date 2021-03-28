using UnityEngine;

namespace UGF.Messages.Runtime.Update
{
    [AddComponentMenu("Unity Game Framework/Messages/Update/Message Late Update", 2000)]
    public class MessageLateUpdateReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onLateUpdate = new Message();

        public Message OnLateUpdate { get { return m_onLateUpdate; } }

        private void LateUpdate()
        {
            m_onLateUpdate.Invoke();
        }
    }
}
