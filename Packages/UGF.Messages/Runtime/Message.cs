using System;
using UnityEngine;

namespace UGF.Messages.Runtime
{
    [Serializable]
    public class Message : IMessage
    {
        [SerializeField] private MessageEvent m_event = new MessageEvent();

        public MessageEvent Event { get { return m_event; } }

        public event MessageHandler Invoked;

        public void Invoke()
        {
            m_event.Invoke();

            Invoked?.Invoke();
        }
    }
}
