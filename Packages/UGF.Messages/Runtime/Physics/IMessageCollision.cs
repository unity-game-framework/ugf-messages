namespace UGF.Messages.Runtime.Physics
{
    public interface IMessageCollision : IMessage
    {
        event MessageCollisionHandler CollisionInvoked;
    }
}
