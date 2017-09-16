using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class EnemyBulletController : MonoBehaviour
{
    [SerializeField]
    float BulletSpeed;
    [SerializeField]
    bool ShouldChasePlayer;

    Rigidbody2D rb;
    Transform Target;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (!(Target = GameObject.FindGameObjectWithTag("Player").transform))
        {
            Destroy(gameObject);
        }
        else if (ShouldChasePlayer)
        {
            transform.rotation = Quaternion.FromToRotation(Vector3.up, Target.position - transform.position);
        }

        StartCoroutine(this.DelayMethod(20f, () => { DestroyBullet(); }));

        rb.velocity = transform.up * BulletSpeed;
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
