using UnityEngine;

namespace UGF.Messages.Runtime.Physics2D
{
    public class MessageTrigger2D : Message, IMessageTrigger2D
    {
        public event MessageTrigger2DHandler TriggerInvoked;

        public void Invoke(Collider2D collider)
        {
            Invoke();

            TriggerInvoked?.Invoke(collider);
        }
    }
}
