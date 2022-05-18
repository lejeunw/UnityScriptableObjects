using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityScriptableObjects.Runtime.Events;

namespace Gameframe.ScriptableObjects.Events
{
  [CustomEditor(typeof(GameEvent))]
  public class GameEventEditor : UnityEditor.Editor
  {
    public override void OnInspectorGUI()
    {
      base.OnInspectorGUI();
      if ( GUILayout.Button("Raise") )
      {
        var gameEvent = target as GameEvent;
        gameEvent.Raise();
      }
    }
  }
}