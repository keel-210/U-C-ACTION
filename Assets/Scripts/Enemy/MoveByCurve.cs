using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByCurve : MonoBehaviour
{
    [SerializeField]
    AnimationCurve velo;
    [SerializeField]
    float Speed;
    [SerializeField]
    bool Move2YAxis;

    Rigidbody2D rb;
    float timeOffset;
	void Awake ()
    {
        rb = GetComponent<Rigidbody2D>();
	}
    private void OnEnable()
    {
        timeOffset = Time.time;
    }
    void FixedUpdate ()
    {
        if (!Move2YAxis)
        {
            rb.velocity = transform.right * Speed * velo.Evaluate(Time.time - timeOffset);
        }
        else
        {
            rb.velocity = transform.up * Speed * velo.Evaluate(Time.time - timeOffset);
        }
    }
}
