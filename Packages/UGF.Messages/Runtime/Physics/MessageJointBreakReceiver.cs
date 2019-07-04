using UnityEngine;

namespace UGF.Messages.Runtime.Physics
{
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
