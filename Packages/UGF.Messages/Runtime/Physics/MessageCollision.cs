using System;
using UnityEngine;

namespace UGF.Messages.Runtime.Physics
{
    [Serializable]
    public class MessageCollision : Message, IMessageCollision
    {
        public event MessageCollisionHandler CollisionInvoked;

        public void Invoke(Collision collision)
        {
            Invoke();

            CollisionInvoked?.Invoke(collision);
        }
    }
}
