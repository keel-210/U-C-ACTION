using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagWaverController : EnemyController, IDamasable
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
    }
    public override void Hit(Vector2 velo)
    {
        anim.SetBool("Hit", true);
    }
    public void GroundHit()
    {
        Instantiate(HitObj, new Vector3(2 + transform.position.x, 0, 0), Quaternion.identity);
        Instantiate(HitObj, new Vector3(-2 + transform.position.x, 0, 0), Quaternion.identity * Quaternion.Euler(0, 180, 0));
    }
}
