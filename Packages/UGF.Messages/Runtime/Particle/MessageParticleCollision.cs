using UnityEngine;

namespace UGF.Messages.Runtime.Particle
{
    public class MessageParticleCollision : Message, IMessageParticleCollision
    {
        public event MessageParticleCollisionHandler CollisionInvoked;

        public void Invoke(GameObject gameObject)
        {
            Invoke();

            CollisionInvoked?.Invoke(gameObject);
        }
    }
}
