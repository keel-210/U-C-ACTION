using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChaser : MonoBehaviour
{

    [SerializeField]
    float BulletSpeed;

    Rigidbody2D rb;
    Transform Target;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (!(Target = GameObject.FindGameObjectWithTag("Player").transform))
        {
            Destroy(gameObject);
        }
        Destroy(gameObject, 20f);
        rb.velocity = transform.up * BulletSpeed;
    }
    private void Update()
    {
        rb.velocity = Vector3.MoveTowards(transform.position, Target.position, BulletSpeed);
    }
    void OnTriggerEnter2D(Collider2D obj)
    {
        Destroy(gameObject);
    }
}
