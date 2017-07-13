using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinuousAttack : MonoBehaviour
{
    [SerializeField]
    int Damage;
    [SerializeField]
    float IntervalTime;
    [SerializeField]
    Object Effect;
    float Timer;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Timer = 0;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Timer += Time.deltaTime;
        if (Timer > 0.2f)
        {
            collision.GetComponent<IDamasable>().TakeDamage(Damage);
            if (Effect)
            {
                Instantiate(Effect, transform.position, transform.rotation);
            }
            Timer = 0;
        }
    }
}
