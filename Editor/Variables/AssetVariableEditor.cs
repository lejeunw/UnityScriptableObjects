using UnityEditor;
using UnityEngine;
using UnityScriptableObjects.Runtime.Variables;

namespace UnityScriptableObjects.Editor.Variables
{
  [CustomEditor( typeof( AssetVariable ) )]
  public class AssetVariableEditor : UnityEditor.Editor
  {
    SerializedProperty assetName;
    SerializedProperty assetPath;

    protected void OnEnable()
    {
      assetName = serializedObject.FindProperty( "assetName" );
      assetPath = serializedObject.FindProperty( "assetPath" );
    }

    public override void OnInspectorGUI()
    {
      base.OnInspectorGUI();
      serializedObject.Update();

      var asset = AssetDatabase.LoadAssetAtPath<Object>( assetPath.stringValue );
      asset = EditorGUILayout.ObjectField( "Asset (NotSerialized)", asset, typeof( GameObject ), false );
      if ( asset != null )
      {
        assetName.stringValue = asset.name;
        assetPath.stringValue = AssetDatabase.GetAssetPath( asset );
      }
      else
      {
        assetPath.stringValue = string.Empty;
      }

      serializedObject.ApplyModifiedProperties();
    }

  }

}