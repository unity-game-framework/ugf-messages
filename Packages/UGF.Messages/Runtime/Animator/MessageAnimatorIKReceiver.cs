using UnityEngine;

namespace UGF.Messages.Runtime.Animator
{
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
