using UnityEngine;

namespace UGF.Messages.Runtime.UI
{
    public class MessageUIRectTransformDimensionsChangeReceiver : MonoBehaviour
    {
        [SerializeField] private Message m_onRectTransformDimensionsChanged = new Message();

        public Message OnRectTransformDimensionsChanged { get { return m_onRectTransformDimensionsChanged; } }

        private void OnRectTransformDimensionsChange()
        {
            m_onRectTransformDimensionsChanged.Invoke();
        }
    }
}
