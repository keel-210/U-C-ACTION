using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class EnemyBulletController : MonoBehaviour
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

        StartCoroutine(this.DelayMethod(10f, () => { DestroyBullet(); }));

        if (Target)
        {
            Vector3 velo = Vector3.Normalize(transform.position - Target.position);
            rb.velocity = BulletSpeed * velo;
        }
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
