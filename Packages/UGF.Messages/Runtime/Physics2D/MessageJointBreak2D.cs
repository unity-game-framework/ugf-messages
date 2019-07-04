using System;
using UnityEngine;

namespace UGF.Messages.Runtime.Physics2D
{
    [Serializable]
    public class MessageJointBreak2D : Message, IMessageJointBreak2D
    {
        public event MessageJointBreak2DHandler JointBreakInvoked;

        public void Invoke(Joint2D brokenJoint)
        {
            if (brokenJoint == null) throw new ArgumentNullException(nameof(brokenJoint));

            Invoke();

            JointBreakInvoked?.Invoke(brokenJoint);
        }
    }
}
