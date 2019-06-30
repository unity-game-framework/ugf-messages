namespace UGF.Messages.Runtime.Physics
{
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
