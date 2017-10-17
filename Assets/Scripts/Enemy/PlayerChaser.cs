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
        StartCoroutine(this.DelayMethod(20f, () => { DestroyBullet(); }));
        rb.velocity = transform.up * BulletSpeed;
    }

    private void Update()
    {
        rb.velocity = Vector3.Lerp(rb.velocity, (transform.position - Target.position).normalized * BulletSpeed, 0.1f);
    }

    void OnTriggerEnter2D(Collider2D obj)
    {
        DestroyBullet();
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
    }
}
