using UnityEngine;

namespace UGF.Messages.Runtime.Physics2D
{
    [AddComponentMenu("Unity Game Framework/Messages/Physics2D/Message Joint Break 2D", 2000)]
    public class MessageJointBreak2DReceiver : MonoBehaviour
    {
        [SerializeField] private MessageJointBreak2D m_onJointBreak = new MessageJointBreak2D();

        public MessageJointBreak2D OnJointBreakMessage { get { return m_onJointBreak; } }

        private void OnJointBreak2D(Joint2D brokenJoint)
        {
            m_onJointBreak.Invoke(brokenJoint);
        }
    }
}
