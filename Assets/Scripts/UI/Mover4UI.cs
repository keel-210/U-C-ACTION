using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover4UI : MonoBehaviour
{
    [SerializeField, Range(0, 10)]
    float time = 1;

    [SerializeField]
    Vector3 endPosition;
    [SerializeField]
    RectTransform rt;

    private float startTime;
    private Vector3 startPosition;
    bool IsMoving;
    void Start()
    {
        endPosition = new Vector3(0, Screen.height, 0);
    }
    public void OnClick()
    {
        if (!IsMoving)
        {
            if (time <= 0)
            {
                rt.position = endPosition;
                enabled = false;
                return;
            }

            startTime = Time.realtimeSinceStartup;
            startPosition = rt.position;
            IsMoving = true;
        }
    }

    void Update()
    {
        if (IsMoving)
        {
            var diff = Time.realtimeSinceStartup - startTime;
            var rate = diff / time;

            rt.position = Vector3.Lerp(startPosition, endPosition, rate);
            if (diff > time)
            {
                rt.position = endPosition;
                endPosition = startPosition;
                IsMoving = false;
            }
        }
    }

    void OnDrawGizmosSelected()
    {
#if UNITY_EDITOR

        if (!UnityEditor.EditorApplication.isPlaying || enabled == false)
        {
            startPosition = transform.position;
        }

        UnityEditor.Handles.Label(endPosition, endPosition.ToString());
        UnityEditor.Handles.Label(startPosition, startPosition.ToString());
#endif
        Gizmos.DrawSphere(endPosition, 0.1f);
        Gizmos.DrawSphere(startPosition, 0.1f);

        Gizmos.DrawLine(startPosition, endPosition);
    }
}