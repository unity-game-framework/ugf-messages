using NUnit.Framework;

namespace UGF.Messages.Runtime.Tests
{
    public class TestMessage
    {
        [Test]
        public void Invoke()
        {
            var message = new Message();
            int value = 0;

            message.Invoked += () => { value++; };
            message.Invoke();

            Assert.AreEqual(1, value);
        }
    }
}
