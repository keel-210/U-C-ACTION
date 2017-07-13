﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Attack : MonoBehaviour
{
    [SerializeField]
    int Damage;
    [SerializeField]
    Object Effect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.GetComponent<IDamasable>().TakeDamage(Damage);
        if (Effect)
        {
            Instantiate(Effect, transform.position, transform.rotation);
        }
    }
}
