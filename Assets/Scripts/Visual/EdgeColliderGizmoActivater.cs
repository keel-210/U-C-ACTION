using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgeColliderGizmoActivater : MonoBehaviour
{
    [SerializeField]
    Color color = new Color(0, 0, 0, 1);
#if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        foreach (EdgeCollider2D e in GetComponents<EdgeCollider2D>())
        {
            UnityEditor.Handles.color = color;
            for (int i = 0; i < e.pointCount - 1; i++)
            {
                UnityEditor.Handles.DrawLine(e.points[i], e.points[i + 1]);
            }

        }
    }
#endif
}
