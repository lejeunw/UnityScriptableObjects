using UnityEditor;
using UnityEngine;
using UnityScriptableObjects.Runtime.Events;

namespace UnityScriptableObjects.Editor.Events
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