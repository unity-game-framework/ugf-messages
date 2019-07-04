namespace UGF.Messages.Runtime.Particle
{
    public interface IMessageParticleCollision : IMessage
    {
        event MessageParticleCollisionHandler CollisionInvoked;
    }
}
