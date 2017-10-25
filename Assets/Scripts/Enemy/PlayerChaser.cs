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
        transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.FromToRotation(Vector3.up, Target.position - transform.position),0.05f);
        rb.velocity = transform.up * BulletSpeed;
    }
    void OnTriggerEnter2D(Collider2D obj)
    {
        Destroy(gameObject);
    }
}
