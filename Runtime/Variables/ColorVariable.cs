using UnityEngine;

namespace UnityScriptableObjects.Runtime.Variables
{
  [CreateAssetMenu(menuName=MenuNames.Variables+"Color")]
  public class ColorVariable : BaseVariable, IVariable<Color>
  {
    [SerializeField]
    private Color value;
    public Color Value
    {
      get => value;
      set => SetProperty(ref this.value, value);
    }
  }
}