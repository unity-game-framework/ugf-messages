using UnityEngine;

namespace UGF.Messages.Runtime.Mouse
{
    [AddComponentMenu("Unity Game Framework/Messages/Mouse/Message Mouse All", 2000)]
    public class MessageMouseAllReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onEnter = new Message();
        [SerializeField] private Message m_onExit = new Message();
        [SerializeField] private Message m_onOver = new Message();
        [SerializeField] private Message m_onUp = new Message();
        [SerializeField] private Message m_onUpAsButton = new Message();
        [SerializeField] private Message m_onDown = new Message();
        [SerializeField] private Message m_onDrag = new Message();

        public Message OnEnter { get { return m_onEnter; } }
        public Message OnExit { get { return m_onExit; } }
        public Message OnOver { get { return m_onOver; } }
        public Message OnUp { get { return m_onUp; } }
        public Message OnUpAsButton { get { return m_onUpAsButton; } }
        public Message OnDown { get { return m_onDown; } }
        public Message OnDrag { get { return m_onDrag; } }

        private void OnMouseEnter()
        {
            m_onEnter.Invoke();
        }

        private void OnMouseExit()
        {
            m_onExit.Invoke();
        }

        private void OnMouseOver()
        {
            m_onOver.Invoke();
        }

        private void OnMouseUp()
        {
            m_onUp.Invoke();
        }

        private void OnMouseUpAsButton()
        {
            m_onUpAsButton.Invoke();
        }

        private void OnMouseDown()
        {
            m_onDown.Invoke();
        }

        private void OnMouseDrag()
        {
            m_onDrag.Invoke();
        }
    }
}
