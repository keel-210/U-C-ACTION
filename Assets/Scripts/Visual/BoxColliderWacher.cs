using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxColliderWacher : MonoBehaviour
{
    [SerializeField]
    Color color;
#if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        foreach (BoxCollider2D e in GetComponents<BoxCollider2D>())
        {
            UnityEditor.Handles.color = color;
            UnityEditor.Handles.DrawSolidRectangleWithOutline(
                new Vector3[] { e.offset + new Vector2(0.5f * e.size.x, 0.5f * e.size.y), e.offset+new Vector2(0.5f*e.size.x,-0.5f*e.size.y)
                ,e.offset+new Vector2(-0.5f*e.size.x,-0.5f*e.size.y),e.offset+new Vector2(-0.5f*e.size.x,0.5f*e.size.y)},
                new Color(0, 0, 1, 0.2f), Color.white);
        }
    }
#endif
}
