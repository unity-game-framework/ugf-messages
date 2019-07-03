using System;
using UnityEngine;

namespace UGF.Messages.Runtime.Particle
{
    [Serializable]
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
