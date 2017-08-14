using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class BulletController : MonoBehaviour
{
    [SerializeField]
    float BulletSpeed;
    [SerializeField]
    Vector2 StartVelo;
    [SerializeField]
    Object Trail;
    GameObject TrailGO;
    Rigidbody2D rb;
    Transform NearestEnemy;
	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
		if(GameObject.FindGameObjectWithTag("Enemy"))
        {
            NearestEnemy = GameObject.FindGameObjectsWithTag("Enemy").OrderBy(x => (x.transform.position - transform.position).magnitude).First().transform;
        }
        rb.velocity = StartVelo;
        StartCoroutine(this.DelayMethod(10f, () => { DestroyBullet(); }));
        TrailGO = (GameObject)Instantiate(Trail);
        TrailGO.transform.parent = transform;
        TrailGO.transform.localPosition = Vector3.zero;
    }
	void FixedUpdate ()
    {
        if (NearestEnemy)
        {
            Vector3 velo = Vector3.Normalize(new Vector3(rb.position.x, rb.position.y, 0) - NearestEnemy.position);
            rb.velocity = Vector2.Lerp(rb.velocity, - velo * BulletSpeed, 0.05f);
        }
    }
    void OnTriggerEnter2D(Collider2D obj)
    {
        DestroyBullet();
    }
    void DestroyBullet()
    {
        TrailGO.transform.parent = null;
        Destroy(gameObject);
    }
}
