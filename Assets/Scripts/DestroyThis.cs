using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyThis : MonoBehaviour
{
    [SerializeField]
    float DestroyTime;
	void Start ()
    {
        StartCoroutine(this.DelayMethod(DestroyTime, () => { Destroy(gameObject); }));
	}
}
