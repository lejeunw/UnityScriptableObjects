using UnityEngine;

namespace UnityScriptableObjects.Runtime.Events
{
  [CreateAssetMenu(menuName = MenuNames.EventMenu+"StringEvent")]
  public class StringGameEvent : BaseGameEvent<string>
  {
    [SerializeField]
    private string _value;
    public override string Value
    {
      get => _value;
      set => _value = value;
    }
  }

}