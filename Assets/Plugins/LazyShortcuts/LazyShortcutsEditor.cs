using UnityEngine;
using UnityEditor;
using System;

public class LazyShortcutsEditor : EditorWindow {
    [MenuItem("Tools/LazyShortcuts/Settings",false,0)]
    public static void ShowWindow()
    {
        EditorWindow[] editorWindows = Resources.FindObjectsOfTypeAll<EditorWindow>();
        var editor = typeof(Editor).Assembly;
        Type inspector = editor.GetType("UnityEditor.InspectorWindow");
        LazyShortcutsEditor window = EditorWindow.GetWindow<LazyShortcutsEditor>("LazyShortcutsSettings", true, inspector);
        window.minSize = new Vector2(275, 50);
    }
    private void OnGUI()
    {
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Reset Transform", GUILayout.MinWidth(140));
        LazyShortcuts.enableResetTransform = EditorGUILayout.Toggle(LazyShortcuts.enableResetTransform);
        EditorGUILayout.EndHorizontal();
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Reset Name", GUILayout.MinWidth(140));
        LazyShortcuts.enableResetName = EditorGUILayout.Toggle(LazyShortcuts.enableResetName);
        EditorGUILayout.EndHorizontal();
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Revert Prefab", GUILayout.MinWidth(140));
        LazyShortcuts.enableRevertPrefab = EditorGUILayout.Toggle(LazyShortcuts.enableRevertPrefab);
        EditorGUILayout.EndHorizontal();
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Save Changes To Prefab", GUILayout.MinWidth(140));
        LazyShortcuts.enableSaveChangesToPrefab = EditorGUILayout.Toggle(LazyShortcuts.enableSaveChangesToPrefab);
        EditorGUILayout.EndHorizontal();
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Toggle Debug Normal View", GUILayout.MinWidth(140));
        LazyShortcuts.enableToggleDebugNormalView = EditorGUILayout.Toggle(LazyShortcuts.enableToggleDebugNormalView);
        EditorGUILayout.EndHorizontal();
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Toggle Lock Unlock Inspector", GUILayout.MinWidth(140));
        LazyShortcuts.enableToggleLockUnlockInspector = EditorGUILayout.Toggle(LazyShortcuts.enableToggleLockUnlockInspector);
        EditorGUILayout.EndHorizontal();
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Toggle Maximize on Play", GUILayout.MinWidth(140));
        LazyShortcuts.enableResetTransform = EditorGUILayout.Toggle(LazyShortcuts.enableMaxPlay);
        EditorGUILayout.EndHorizontal();
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Toggle Mute on Play", GUILayout.MinWidth(140));
        LazyShortcuts.enableResetTransform = EditorGUILayout.Toggle(LazyShortcuts.enableMutePlay);
        EditorGUILayout.EndHorizontal();
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Toggle Stats", GUILayout.MinWidth(140));
        LazyShortcuts.enableResetTransform = EditorGUILayout.Toggle(LazyShortcuts.enableStats);
        EditorGUILayout.EndHorizontal();
    }
}
