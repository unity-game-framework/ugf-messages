using UnityEngine;

namespace UGF.Messages.Runtime.Animator
{
    public class MessageAnimatorMoveReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onMove = new Message();

        public Message OnMove { get { return m_onMove; } }

        private void OnAnimatorMove()
        {
            m_onMove.Invoke();
        }
    }
}
