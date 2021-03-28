using UnityEngine;

namespace UGF.Messages.Runtime.Mouse
{
    [AddComponentMenu("Unity Game Framework/Messages/Mouse/Message Mouse Enter", 2000)]
    public class MessageMouseEnterReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onEnter = new Message();

        public Message OnEnter { get { return m_onEnter; } }

        private void OnMouseEnter()
        {
            m_onEnter.Invoke();
        }
    }
}
