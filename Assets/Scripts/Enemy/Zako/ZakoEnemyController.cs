using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZakoEnemyController : EnemyController
{
    public override void TakeDamage(int damage)
    {
        health -= damage;
    }
    public override void Hit(Vector2 velo)
    {
        IsHit = true;
        rb.velocity = new Vector2(velo.x * Direction, velo.y);
    }
}