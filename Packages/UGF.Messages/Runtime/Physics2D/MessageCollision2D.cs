using System;
using UnityEngine;

namespace UGF.Messages.Runtime.Physics2D
{
    [Serializable]
    public class MessageCollision2D : Message, IMessageCollision2D
    {
        public event MessageCollision2DHandler CollisionInvoked;

        public void Invoke(Collision2D collision)
        {
            if (collision == null) throw new ArgumentNullException(nameof(collision));

            Invoke();

            CollisionInvoked?.Invoke(collision);
        }
    }
}
