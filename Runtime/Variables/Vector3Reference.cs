using UnityEngine;

namespace UnityScriptableObjects.Runtime.Variables
{
    [System.Serializable]
    public class Vector3Reference : VariableReference<Vector3, Vector3Variable>
    {
        public static implicit operator Vector3(Vector3Reference reference)
        {
            return reference.Value;
        }
    }
}