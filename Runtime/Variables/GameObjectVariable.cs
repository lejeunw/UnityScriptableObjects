using UnityEngine;

namespace UnityScriptableObjects.Runtime.Variables
{
  [CreateAssetMenu(menuName=MenuNames.Variables+"GameObject")]
  public class GameObjectVariable : BaseVariable, IVariable<GameObject>
  {
    [SerializeField]
    private bool clearOnEnable = false;

    [SerializeField]
    private GameObject gameObject = null;

    public GameObject Value
    {
      get => gameObject;
      set
      {
        if (gameObject != value)
        {
          gameObject = value;
          OnPropertyChanged();
        }
      }
    }

    private void OnEnable()
    {
      if (clearOnEnable)
      {
        Value = null;
      }
    }
    
  }
}