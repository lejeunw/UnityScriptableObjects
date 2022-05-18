using System;
using UnityEngine;
using UnityEngine.Events;

namespace UnityScriptableObjects.Runtime.Events
{

  public class StringGameEventListener : BaseGameEventListener<string>
  {

    [SerializeField] 
    private StringGameEvent stringGameEvent = null;

    [Serializable]
    public class StringEvent : UnityEvent<string> { }

    [SerializeField] 
    private StringEvent onEventRaised = null;

    protected override GameEvent InternalEvent
    {
      get { return stringGameEvent; }
    }

    public override void OnEventRaised(GameEvent gameEventParam)
    {
      onEventRaised.Invoke(stringGameEvent.Value);
    }

  }

}