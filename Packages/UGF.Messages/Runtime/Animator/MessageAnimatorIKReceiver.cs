using UnityEngine;

namespace UGF.Messages.Runtime.Animator
{
#if UGF_HAS_MODULE_ANIMATION
    [RequireComponent(typeof(UnityEngine.Animator))]
#endif
    [AddComponentMenu("Unity Game Framework/Messages/Animator/Message Animator IK", 2000)]
    public class MessageAnimatorIKReceiver : MonoBehaviour
    {
        [SerializeField] private MessageAnimatorIK m_onIK = new MessageAnimatorIK();

        public MessageAnimatorIK OnIK { get { return m_onIK; } }

        private void OnAnimatorIK(int layerIndex)
        {
            m_onIK.Invoke(layerIndex);
        }
    }
}
