namespace UGF.Messages.Runtime.Physics2D
{
    public interface IMessageJointBreak2D : IMessage
    {
        event MessageJointBreak2DHandler JointBreakInvoked;
    }
}
