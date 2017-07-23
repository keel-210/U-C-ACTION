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
    Vector2 HitVelo;
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
            var d = collision.GetComponent<IDamasable>();
            if (d != null)
            {
                d.TakeDamage(Damage);
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
                h.Hit(new Vector2(HitVelo.x*dir,HitVelo.y));
            }
            if (Effect)
            {
                Instantiate(Effect, transform.position, transform.rotation);
            }
            Timer = 0;
        }
    }
}
