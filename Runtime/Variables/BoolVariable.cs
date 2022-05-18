using UnityEngine;

namespace UnityScriptableObjects.Runtime.Variables
{
    [CreateAssetMenu(menuName = MenuNames.Variables + "Bool")]
    public class BoolVariable : BaseVariable, IVariable<bool>
    {
        [SerializeField] private bool value;

        public bool Value
        {
            get => value;
            set => SetProperty(ref this.value, value);
        }

        public override string ToText()
        {
            return value.ToString();
        }
    }
}