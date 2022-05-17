namespace UnityScriptableObjects.Runtime.Variables
{
  public interface IVariable<T>
  {
    T Value { get; set; }
  }
}
