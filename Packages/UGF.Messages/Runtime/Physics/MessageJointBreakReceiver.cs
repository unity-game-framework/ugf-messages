using UnityEngine;

namespace UGF.Messages.Runtime.Physics
{
    [AddComponentMenu("Unity Game Framework/Messages/Physics/Message Joint Break", 2000)]
    public class MessageJointBreakReceiver : MonoBehaviour
    {
        [SerializeField] private MessageJointBreak m_onJointBreak = new MessageJointBreak();

        public MessageJointBreak OnJointBreakMessage { get { return m_onJointBreak; } }

        private void OnJointBreak(float breakForce)
        {
            m_onJointBreak.Invoke(breakForce);
        }
    }
}
