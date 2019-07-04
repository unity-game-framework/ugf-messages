using System;
using UnityEngine;

namespace UGF.Messages.Runtime.Physics2D
{
    [Serializable]
    public class MessageTrigger2D : Message, IMessageTrigger2D
    {
        public event MessageTrigger2DHandler TriggerInvoked;

        public void Invoke(Collider2D collider)
        {
            if (collider == null) throw new ArgumentNullException(nameof(collider));

            Invoke();

            TriggerInvoked?.Invoke(collider);
        }
    }
}
