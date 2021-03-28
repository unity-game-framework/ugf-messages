using UnityEngine;

namespace UGF.Messages.Runtime.Update
{
    [AddComponentMenu("Unity Game Framework/Messages/Update/Message Fixed Update", 2000)]
    public class MessageFixedUpdateReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onFixedUpdate = new Message();

        public Message OnFixedUpdate { get { return m_onFixedUpdate; } }

        private void FixedUpdate()
        {
            m_onFixedUpdate.Invoke();
        }
    }
}
