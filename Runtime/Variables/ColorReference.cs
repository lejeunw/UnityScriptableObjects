using UnityEngine;

namespace UnityScriptableObjects.Runtime.Variables
{
    [System.Serializable]
    public class ColorReference : VariableReference<Color, ColorVariable>
    {
        public static implicit operator Color(ColorReference reference)
        {
            return reference.Value;
        }
    }
}