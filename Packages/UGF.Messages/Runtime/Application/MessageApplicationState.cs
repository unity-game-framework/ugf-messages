namespace UGF.Messages.Runtime.Application
{
    public class MessageApplicationState : Message, IMessageApplicationState
    {
        public event MessageApplicationStateHandler StateInvoked;

        public void Invoke(bool state)
        {
            Invoke();

            StateInvoked?.Invoke(state);
        }
    }
}
