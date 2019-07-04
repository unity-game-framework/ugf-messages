using NUnit.Framework;

namespace UGF.Messages.Runtime.Tests
{
    public class TestMessageEvent
    {
        [Test]
        public void Invoke()
        {
            var messageEvent = new MessageEvent();
            int value = 0;

            messageEvent.AddListener(() => value++);
            messageEvent.Invoke();

            Assert.AreEqual(1, value);
        }
    }
}
