using UnityEngine;
using UnityEngine.Events;

namespace UnityScriptableObjects.Runtime.Events
{
  public class GameEventListener : MonoBehaviour, IGameEventListener
  {
    public GameEvent gameEvent;
    public UnityEvent action;

    private void OnEnable()
    {
      gameEvent.AddListener(this);
    }

    private void OnDisable()
    {
      gameEvent.RemoveListener(this);
    }

    public void OnEventRaised(GameEvent gameEventParam)
    {
      action.Invoke();
    }
  }
}
