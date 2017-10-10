using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateController : EnemyController
{
    [SerializeField]
    GameObject HitObj;

    Animator anim;
    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public override void TakeDamage(int damage)
    {
        health -= damage;
        if(health < 1500)
        {
            rb.gravityScale = 0;
        }
        if(health < 0)
        {
            rb.gravityScale = 1;
        }
    }

    public override void Hit(Vector2 velo)
    {
        anim.SetBool("Hit", true);
    }

    public void GroundHit()
    {
        Instantiate(HitObj, transform.position + new Vector3(6, 0, 0), Quaternion.identity);
        Instantiate(HitObj, transform.position + new Vector3(-6, 0, 0), Quaternion.identity * Quaternion.Euler(0, 180, 0));
    }
}
