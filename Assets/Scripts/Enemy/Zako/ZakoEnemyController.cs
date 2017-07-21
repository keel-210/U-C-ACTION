using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZakoEnemyController : EnemyController
{
    public override void TakeDamage(int damage)
    {
        health -= damage;
    }
}
public enum ZakoAttackCollider
{ }
