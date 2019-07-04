using System;

namespace UGF.Messages.Runtime.Physics
{
    [Serializable]
    public class MessageJointBreak : Message, IMessageJointBreak
    {
        public event MessageJointBreakHandler JointBreakInvoked;

        public void Invoke(float breakForce)
        {
            Invoke();

            JointBreakInvoked?.Invoke(breakForce);
        }
    }
}
