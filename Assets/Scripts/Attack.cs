using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Attack : MonoBehaviour
{
    [SerializeField]
    int Damage;
    [SerializeField]
    Vector2 HitVelo;
    [SerializeField]
    Object Effect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var d = collision.GetComponent<IDamasable>();
        if (d != null)
        {
            d.TakeDamage(Damage);
        }
        var h = collision.GetComponent<IHitable>();
        if(h != null)
        {
            float dir;
            if(transform.rotation.eulerAngles.y == 0)
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
    }
}
