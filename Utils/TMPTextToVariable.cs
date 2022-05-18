using TMPro;
using UnityEngine;

namespace UnityScriptableObjects.Utils
{
    [RequireComponent(typeof(TMP_Text))]
    public class TMPTextToVariable : BindableUI
    {
        [SerializeField]
        private TMP_Text textComponent;

        private void Reset()
        {
            textComponent = GetComponent<TMP_Text>();
        }
    
        public override void ApplyChange()
        {
            textComponent.text = variable.ToText();
        }
    }
}