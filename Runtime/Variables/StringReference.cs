namespace UnityScriptableObjects.Runtime.Variables
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