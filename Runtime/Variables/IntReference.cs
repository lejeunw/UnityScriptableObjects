namespace UnityScriptableObjects.Runtime.Variables
{
    [System.Serializable]
    public class IntReference : VariableReference<int, IntVariable>
    {
        // permits a IntReference to be used as an int if used as a value / getter only
        // does not work to Assign to an IntReference, copy will be bit-by-bit
        public static implicit operator int(IntReference reference) => reference.Value;
    }
}