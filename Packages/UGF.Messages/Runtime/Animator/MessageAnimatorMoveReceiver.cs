using UnityEngine;

namespace UGF.Messages.Runtime.Animator
{
#if UGF_HAS_MODULE_ANIMATION
    [RequireComponent(typeof(UnityEngine.Animator))]
#endif
    [AddComponentMenu("Unity Game Framework/Messages/Animator/Message Animator Move", 2000)]
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
