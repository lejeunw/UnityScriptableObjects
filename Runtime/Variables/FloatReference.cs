namespace UnityScriptableObjects.Runtime.Variables
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