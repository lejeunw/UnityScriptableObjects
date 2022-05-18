using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gameframe.ScriptableObjects.Variables
{
    [System.Serializable]
    public class FloatReference : VariableReference<float, FloatVariable>
    {
        public static implicit operator float(FloatReference reference)
        {
            return reference.Value;
        }
    }
}