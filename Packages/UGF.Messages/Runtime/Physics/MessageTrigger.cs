using System;
using UnityEngine;

namespace UGF.Messages.Runtime.Physics
{
    [Serializable]
    public class MessageTrigger : Message, IMessageTrigger
    {
        public event MessageTriggerHandler TriggerInvoked;

        public void Invoke(Collider collider)
        {
            if (collider == null) throw new ArgumentNullException(nameof(collider));

            Invoke();

            TriggerInvoked?.Invoke(collider);
        }
    }
}
