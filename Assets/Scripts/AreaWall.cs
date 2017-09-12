using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaWall : MonoBehaviour
{
	void Start ()
    {
        Camera camera = Camera.main.GetComponent<Camera>();
        float cameraWidthHalf = camera.orthographicSize * camera.aspect;
    }
}
