using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleSetter : MonoBehaviour {

    [SerializeField]
    Vector3 targetScale;
    [SerializeField]
    float time;

    float timer;
    Vector3 rate;
	
	void Update ()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, targetScale, 0.05f);
        timer += Time.deltaTime;
        if(timer > time)
        {
            transform.localScale = targetScale;
        }
	}
}
