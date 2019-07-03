namespace UGF.Messages.Runtime.Animator
{
    public class MessageAnimatorIK : Message, IMessageAnimatorIK
    {
        public event MessageAnimatorIKHandler LayerInvoked;

        public void Invoke(int layerIndex)
        {
            Invoke();

            LayerInvoked?.Invoke(layerIndex);
        }
    }
}
