namespace UnityScriptableObjects.Runtime.Events
{
  public interface IGameEventListener
  {
    void OnEventRaised(GameEvent gameEvent);
  }
}
