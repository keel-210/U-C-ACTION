using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagWaverController : EnemyController, IDamasable, IShield
{
    [SerializeField]
    int DefaultShield;
    [SerializeField]
    GameObject HitObj;

    public int Shield { get; set; }
    Animator anim;

    void Awake()
    {
        Shield = DefaultShield;
        anim = GetComponent<Animator>();
    }

    public override void TakeDamage(int damage)
    {
        if (anim.GetBool("Down"))
        {
            health -= damage;
        }
        else
        {
            if (Shield > 0)
            {
                Shield -= damage;
                if (Shield < 0)
                {
                    anim.SetBool("Down", true);
                }
            }
            else
            {
                Shield = DefaultShield;
            }
        }
    }
    public override void Hit(Vector2 velo)
    {
        anim.SetBool("Hit", true);
    }
    public void GroundHit()
    {

    }
    public void Recovery()
    {

    }
}
