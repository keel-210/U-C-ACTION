using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHorizontaly : MonoBehaviour
{
    [SerializeField]
    Vector2 Speed;
    Rigidbody2D rb;
	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        float dir = 1;
        if(transform.rotation.eulerAngles.y == 180)
        {
            dir = -1;
        }
        rb.velocity = dir * Speed;
	}
	
	void Update ()
    {
		
	}
}
