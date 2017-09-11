using System;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
using UnityEditorInternal;
#endif
public class EnemyListEmitter : MonoBehaviour
{
    public List<PrefabListEmitter.EmitPrefab> list = new List<PrefabListEmitter.EmitPrefab>();

    bool activate;
    float Timer;

    private void OnEnable()
    {
        activate = true;
        Timer = 0;
    }

    public void Update()
    {
        if (activate)
        {
            Timer += Time.deltaTime;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Time < Timer)
                {
                    GameObject obj = (GameObject)Instantiate(list[i].Prefab, list[i].Pos + transform.position, Quaternion.Euler(list[i].Rot));
                    obj.transform.parent = transform;
                    list.Remove(list[i]);
                }
            }
        }
    }
}
[CanEditMultipleObjects]
[CustomEditor(typeof(EnemyListEmitter))]
public class EnemyListDrawer : Editor
{
    private ReorderableList RL;
    private SerializedProperty ListProp;
    private void OnEnable()
    {
        ListProp = serializedObject.FindProperty("list");
        RL = new ReorderableList(serializedObject, ListProp);
        RL.elementHeight = 80;
        RL.drawHeaderCallback = (rect) =>
        {
            EditorGUI.LabelField(rect, "Waves");
        };
        RL.drawElementCallback = (rect, index, isActive, isFocused) =>
        {
            var element = ListProp.GetArrayElementAtIndex(index);
            EditorGUI.PropertyField(rect, element);
        };
    }
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        serializedObject.Update();
        RL.DoLayoutList();
        serializedObject.ApplyModifiedProperties();
    }
}