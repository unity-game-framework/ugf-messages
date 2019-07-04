using System;
using UnityEngine;

namespace UGF.Messages.Runtime.Render
{
    [Serializable]
    public class MessageRenderImage : Message, IMessageRenderImage
    {
        public event MessageRenderImageHandler RenderImageInvoked;

        public void Invoke(RenderTexture source, RenderTexture destination)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (destination == null) throw new ArgumentNullException(nameof(destination));

            Invoke();

            RenderImageInvoked?.Invoke(source, destination);
        }
    }
}
