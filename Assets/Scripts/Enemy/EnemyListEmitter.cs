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
#if UNITY_EDITOR
    void OnDrawGizmosSelected()
    {
        Vector2 w = new Vector2(transform.position.x, transform.position.y);
        Handles.DrawSolidRectangleWithOutline(
                new Vector3[] { w + new Vector2(10, 10), w + new Vector2(-10, 10), w + new Vector2(-10, 0), w + new Vector2(10, 0) },
                new Color(0, 1, 0, 0.2f), new Color(1, 1, 1, 0.2f));
    }
#endif
}
#if UNITY_EDITOR
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
    private void OnSceneGUI()
    {
        var component = target as EnemyListEmitter;
        List<PrefabListEmitter.EmitPrefab> l = component.list;
        for (int i = 0; i < l.Count; i++)
        {
            l[i].Pos = Handles.FreeMoveHandle(l[i].Pos + component.transform.position, Quaternion.identity, 0.25f, Vector3.forward, Handles.RectangleCap) - component.transform.position;
        }
    }
    
}
#endif