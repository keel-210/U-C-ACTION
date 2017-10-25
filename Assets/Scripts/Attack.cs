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
    [SerializeField]
    bool DefaultActive;

    bool HitStopped;

    private void Start()
    {
        gameObject.SetActive(DefaultActive);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var d = collision.GetComponentInParent<IDamasable>();
        if (d != null)
        {
            d.TakeDamage(Damage);
            if(collision.tag == "Enemy")
            {
                PlayerController pc = transform.root.GetComponent<PlayerController>();
                pc.HitStopped = true;
                Time.timeScale = 0;
                iTween.ShakePosition(Camera.main.gameObject, iTween.Hash("x", 0.1f, "y", 0.1f, "time", 0.2f));
            }
        }
        var h = collision.GetComponentInParent<IHitable>();
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
