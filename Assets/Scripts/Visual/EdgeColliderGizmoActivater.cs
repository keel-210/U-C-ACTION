using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgeColliderGizmoActivater : MonoBehaviour
{
    [SerializeField]
    Color color;
#if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        foreach(EdgeCollider2D e in GetComponents<EdgeCollider2D>())
        {
            UnityEditor.Handles.color = color;
            UnityEditor.Handles.DrawLine(e.points[0], e.points[1]);
        }
    }
#endif
}
