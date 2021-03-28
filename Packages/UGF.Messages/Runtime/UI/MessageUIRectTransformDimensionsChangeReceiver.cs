using UnityEngine;

namespace UGF.Messages.Runtime.UI
{
    [AddComponentMenu("Unity Game Framework/Messages/UI/Message UI RectTransform Dimensions Changed", 2000)]
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
