using System.Runtime.CompilerServices;
using UnityScriptableObjects.Runtime.BindingSupport;
using UnityScriptableObjects.Runtime.Events;

namespace UnityScriptableObjects.Runtime.Variables
{
    public abstract class BaseVariable : BindableScriptableObject
    {
        protected GameEvent onValueChanged;

        public GameEvent OnValueChanged
        {
            get
            {
                if (onValueChanged == null)
                {
                    onValueChanged = CreateInstance<GameEvent>();
                }
                return onValueChanged;
            }
        }

        public abstract string ToText();

        public void OnValidate()
        {
            OnValueChanged.Raise();
        }

        /// <summary>
        /// INotifyPropertyChanged interface implemented to support Gameframe.Bindings
        /// </summary>
#region INotifyPropertyChanged
        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if (onValueChanged != null)
            {
                onValueChanged.Raise();
            }
        }
#endregion

    }
}

