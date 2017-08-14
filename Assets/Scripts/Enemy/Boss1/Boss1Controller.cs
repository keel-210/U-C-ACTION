using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1Controller : EnemyController
{
    public override void TakeDamage(int damage)
    {
        health -= damage;
    }
    public override void Hit(Vector2 velo)
    {
    }
}
