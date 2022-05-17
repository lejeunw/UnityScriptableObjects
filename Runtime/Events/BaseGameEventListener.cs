using UnityEngine;

namespace UnityScriptableObjects.Runtime.Events
{
  public abstract class BaseGameEventListener<T> : MonoBehaviour, IGameEventListener
  {

    protected abstract GameEvent InternalEvent { get; }

    private void OnEnable()
    {
      InternalEvent.AddListener(this);
    }

    private void OnDisable()
    {
      InternalEvent.RemoveListener(this);
    }

    public virtual void OnEventRaised(GameEvent gameEvent)
    {
     
    }
  }
}
