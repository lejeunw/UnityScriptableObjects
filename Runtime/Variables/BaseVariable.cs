using System.Runtime.CompilerServices;
using UnityEngine;
using UnityScriptableObjects.Runtime.BindingSupport;
using UnityScriptableObjects.Runtime.Events;

namespace UnityScriptableObjects.Runtime.Variables
{
    public class BaseVariable : BindableScriptableObject
    {
        [SerializeField]
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

        public void OnValidate()
        {
            if (onValueChanged != null)
                onValueChanged.Raise();
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

