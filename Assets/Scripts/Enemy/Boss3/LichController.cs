using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LichController : EnemyController, IDamasable
{
    Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public override void TakeDamage(int damage)
    {
        health -= damage;
    }
    public override void Hit(Vector2 velo)
    {
        anim.SetBool("Hit", true);
    }
}
