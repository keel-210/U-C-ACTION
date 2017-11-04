using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotator : MonoBehaviour
{
    [SerializeField]
    float XSpeed, YSpeed, ZSpeed;

	void LateUpdate ()
    {
        transform.rotation *= Quaternion.Euler(XSpeed, YSpeed, ZSpeed);
	}
}
