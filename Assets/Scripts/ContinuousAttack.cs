﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinuousAttack : MonoBehaviour
{
    [SerializeField]
    int Damage;
    [SerializeField]
    Vector2 HitVelo;
    [SerializeField]
    Object Effect;
    [SerializeField]
    bool DefaultActive;

    Collider2D col;
    float Timer;
    private void Start()
    {
        col = GetComponent<Collider2D>();
        gameObject.SetActive(DefaultActive);
    }
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        var d = collision.GetComponentInParent<IDamasable>();
        if (d != null)
        {
            d.TakeDamage(Damage);
            if (Effect)
            {
                Instantiate(Effect, transform.position, transform.rotation);
            }
        }
        var h = collision.GetComponent<IHitable>();
        if (h != null)
        {
            float dir;
            if (transform.rotation.eulerAngles.y == 0)
            {
                dir = 1;
            }
            else
            {
                dir = -1;
            }
            h.Hit(new Vector2(HitVelo.x * dir, HitVelo.y));
        }
    }
}
