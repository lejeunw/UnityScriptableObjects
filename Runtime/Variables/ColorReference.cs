using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gameframe.ScriptableObjects.Variables
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