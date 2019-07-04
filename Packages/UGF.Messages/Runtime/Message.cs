using System;
using UnityEngine;

namespace UGF.Messages.Runtime
{
    /// <summary>
    /// Represents a serializable message without arguments and Unity event message available via an inspector.
    /// </summary>
    [Serializable]
    public class Message : IMessage
    {
        [SerializeField] private MessageEvent m_event = new MessageEvent();

        /// <summary>
        /// Gets the serializable message event which available via an inspector.
        /// </summary>
        public MessageEvent Event { get { return m_event; } }

        public event MessageHandler Invoked;

        /// <summary>
        /// Invokes message.
        /// </summary>
        public void Invoke()
        {
            m_event.Invoke();

            Invoked?.Invoke();
        }
    }
}
