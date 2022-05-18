using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gameframe.ScriptableObjects.Variables
{
    [System.Serializable]
    public class StringReference : VariableReference<string, StringVariable>
    {
        public static implicit operator string(StringReference reference)
        {
            return reference.Value;
        }
    }
}