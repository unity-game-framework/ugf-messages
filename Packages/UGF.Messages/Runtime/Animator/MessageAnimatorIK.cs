using System;

namespace UGF.Messages.Runtime.Animator
{
    [Serializable]
    public class MessageAnimatorIK : Message, IMessageAnimatorIK
    {
        public event MessageAnimatorIKHandler IKInvoked;

        public void Invoke(int layerIndex)
        {
            Invoke();

            IKInvoked?.Invoke(layerIndex);
        }
    }
}
