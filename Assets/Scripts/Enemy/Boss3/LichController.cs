using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LichController : EnemyController, IDamasable
{
    [SerializeField]
    GameObject shot1, shot2, groundHitShot, ChaserShot;

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
    public void Shoot1()
    {

    }
    public void Shoot2()
    {

    }
    public void GroundHit()
    {

    }
    public void Chaser()
    {

    }
}
