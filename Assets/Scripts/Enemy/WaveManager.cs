using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
#if UNITY_EDITOR
using UnityEditor;
using UnityEditorInternal;
#endif

public class WaveManager : MonoBehaviour
{
    [SerializeField]
    bool ReferenceXorY;
    public List<WaveAndPos> Waves = new List<WaveAndPos>();

    Transform player;
    Transform NowWave;
    EnemyListEmitter NowEmitter;
    WaveAndPos NowWAP;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        foreach (WaveAndPos wp in Waves)
        {
            if (ReferenceXorY)
            {
                if (player.transform.position.x > wp.Pos.x)
                {
                    if (!wp.Wave.activeInHierarchy)
                        Camera.main.GetComponent<Chaser4Camera>().Fix(wp.Pos,CameraFixType.xFix);
                    wp.Wave.SetActive(true);
                    NowWave = wp.Wave.transform;
                    NowEmitter = wp.Wave.GetComponent<EnemyListEmitter>();
                    NowWAP = wp;
                }
            }
            else
            {
                if (player.transform.position.y > wp.Pos.y)
                {
                    if (!wp.Wave.activeInHierarchy)
                        Camera.main.GetComponent<Chaser4Camera>().Fix(wp.Pos,CameraFixType.yFix);
                    wp.Wave.SetActive(true);
                    NowWave = wp.Wave.transform;
                    NowEmitter = wp.Wave.GetComponent<EnemyListEmitter>();
                    NowWAP = wp;
                }
            }
        }
        if (NowEmitter)
        {
            if (NowEmitter.list.Count == 0 && NowWave.childCount == 0)
            {
                Camera.main.GetComponent<Chaser4Camera>().UnFix();
                Waves.Remove(NowWAP);
            }
        }
    }

    [Serializable]
    public class WaveAndPos
    {
        public Vector2 Pos;
        public GameObject Wave;
    }
#if UNITY_EDITOR
    void OnDrawGizmosSelected()
    {
        foreach (WaveAndPos w in Waves)
        {
            UnityEditor.Handles.DrawSolidRectangleWithOutline(
                new Vector3[] { w.Pos + new Vector2(10, 10), w.Pos + new Vector2(-10, 10), w.Pos + new Vector2(-10, 0), w.Pos + new Vector2(10, 0) },
                new Color(0, 1, 0, 0.2f), new Color(1, 1, 1, 0.2f));
        }
    }
#endif
}

public class WaveAndPosAttribute : PropertyAttribute { }
#if UNITY_EDITOR
[CanEditMultipleObjects]
[CustomEditor(typeof(WaveManager))]
public class WaveAndPosDrawer : Editor
{
    private ReorderableList RL;
    private SerializedProperty ListProp;
    private void OnEnable()
    {
        ListProp = serializedObject.FindProperty("Waves");
        RL = new ReorderableList(serializedObject, ListProp);
        RL.elementHeight = 40;

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
        WaveManager component = target as WaveManager;
        List<WaveManager.WaveAndPos> wp = component.Waves;
        for (int i = 0; i < wp.Count; i++)
        {
            wp[i].Pos = Handles.PositionHandle(wp[i].Pos, Quaternion.identity);
            wp[i].Wave.transform.position = wp[i].Pos;
        }
    }
}

[CanEditMultipleObjects, CustomPropertyDrawer(typeof(WaveManager.WaveAndPos))]
public class WAPAttribute : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        using (new EditorGUI.PropertyScope(position, label, property))
        {
            position.height = EditorGUIUtility.singleLineHeight;
            var ele1 = property.FindPropertyRelative("Pos");
            var ele2 = property.FindPropertyRelative("Wave");

            var ele1Rect = new Rect(position)
            {
                height = position.height
            };
            var ele2Rect = new Rect(position)
            {
                height = position.height,
                y = ele1Rect.y + EditorGUIUtility.singleLineHeight + 2
            };

            EditorGUI.PropertyField(ele1Rect, ele1);
            EditorGUI.PropertyField(ele2Rect, ele2);
        }
    }
}
#endif
