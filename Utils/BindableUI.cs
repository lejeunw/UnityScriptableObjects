using UnityEngine;
using UnityScriptableObjects.Runtime.Events;
using UnityScriptableObjects.Runtime.Variables;

namespace UnityScriptableObjects.Utils
{
    public abstract class BindableUI : MonoBehaviour, IGameEventListener
    {
        [Header("Base data")]
        public BaseVariable variable;

        [HideInInspector]
        public GameEvent gameEvent;

        private void OnEnable()
        {
            ApplyChange();
            gameEvent = variable.OnValueChanged;
            gameEvent.AddListener(this);
        }

        private void OnDisable()
        {
            gameEvent.RemoveListener(this);
        }

        public void OnEventRaised(GameEvent gameEventParam)
        {
            ApplyChange();
        }

        public abstract void ApplyChange();
    }
}