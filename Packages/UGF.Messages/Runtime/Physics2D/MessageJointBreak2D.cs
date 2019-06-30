using UnityEngine;

namespace UGF.Messages.Runtime.Physics2D
{
    public class MessageJointBreak2D : Message, IMessageJointBreak2D
    {
        public event MessageJointBreak2DHandler JointBreakInvoked;

        public void Invoke(Joint2D brokenJoint)
        {
            Invoke();

            JointBreakInvoked?.Invoke(brokenJoint);
        }
    }
}
