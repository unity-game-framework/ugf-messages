namespace UGF.Messages.Runtime.Physics2D
{
    public interface IMessageCollision2D : IMessage
    {
        event MessageCollision2DHandler CollisionInvoked;
    }
}
