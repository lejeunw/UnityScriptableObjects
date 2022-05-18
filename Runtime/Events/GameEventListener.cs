using System.Collections;
using System.Collections.Generic;
using Gameframe.ScriptableObjects.Variables;
using UnityEngine;
using UnityEngine.Events;

namespace Gameframe.ScriptableObjects.Events
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
