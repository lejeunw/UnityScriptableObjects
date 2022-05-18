using System;
using System.Collections;
using System.Collections.Generic;
using Gameframe.ScriptableObjects.Events;
using Gameframe.ScriptableObjects.Variables;
using UnityEngine;
using UnityEngine.UI;

namespace UnityScriptableObjects.Utils
{
    [RequireComponent(typeof(Slider))]
    public class SliderToVariable : BindableUI
    {
        [Header("Slider Data")]
        [SerializeField]
        private Slider sliderComponent;

        [SerializeField]
        private SliderDataType dataToSync;

        private void Reset()
        {
            sliderComponent = GetComponent<Slider>();
            dataToSync = SliderDataType.Value;
        }

        public override void ApplyChange()
        {
            switch (dataToSync)
            {
                case SliderDataType.Value:
                    SyncValue();
                    break;
                case SliderDataType.Max:
                    SyncMax();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void SyncValue()
        {
            sliderComponent.value = variable switch
            {
                IntVariable intVariable => intVariable.Value,
                FloatVariable floatVariable => floatVariable.Value,
                _ => sliderComponent.value
            };
        }

        private void SyncMax()
        {
            sliderComponent.maxValue = variable switch
            {
                IntVariable intVariable => intVariable.Value,
                FloatVariable floatVariable => floatVariable.Value,
                _ => sliderComponent.maxValue
            };
        }
    }

    internal enum SliderDataType
    {
        Value,
        Max
    }
}