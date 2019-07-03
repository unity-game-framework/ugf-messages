using UnityEngine;

namespace UGF.Messages.Runtime.Animator
{
    public class MessageAnimatorAllReceiver : MonoBehaviour
    {
        [SerializeField] private MessageAnimatorIK m_onIK = new MessageAnimatorIK();
        [SerializeField] private Message m_onMove = new Message();

        public MessageAnimatorIK OnIK { get { return m_onIK; } }
        public Message OnMove { get { return m_onMove; } }

        private void OnAnimatorIK(int layerIndex)
        {
            m_onIK.Invoke(layerIndex);
        }

        private void OnAnimatorMove()
        {
            m_onMove.Invoke();
        }
    }
}
