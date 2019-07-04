using System;
using UnityEngine.Events;

namespace UGF.Messages.Runtime
{
    /// <summary>
    /// Represents message without arguments as serializable Unity event.
    /// </summary>
    [Serializable]
    public class MessageEvent : UnityEvent
    {
    }
}
