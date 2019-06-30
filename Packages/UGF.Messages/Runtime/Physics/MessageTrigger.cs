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
            Invoke();

            TriggerInvoked?.Invoke(collider);
        }
    }
}
