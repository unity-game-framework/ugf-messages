namespace UGF.Messages.Runtime
{
    /// <summary>
    /// Represents a message which can be subscribed to.
    /// </summary>
    public interface IMessage
    {
        /// <summary>
        /// The event which occurs on invoke of the message.
        /// </summary>
        event MessageHandler Invoked;
    }
}
