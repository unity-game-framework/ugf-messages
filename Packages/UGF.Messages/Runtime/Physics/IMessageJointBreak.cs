namespace UGF.Messages.Runtime.Physics
{
    public interface IMessageJointBreak : IMessage
    {
        event MessageJointBreakHandler JointBreakInvoked;
    }
}
