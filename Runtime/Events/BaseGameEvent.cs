namespace UnityScriptableObjects.Runtime.Events
{
  public abstract class BaseGameEvent<T> : GameEvent
  {
    public abstract T Value { get; set; }

    public void Raise(T value)
    {
      Value = value;
      Raise();
    }
  }
}
