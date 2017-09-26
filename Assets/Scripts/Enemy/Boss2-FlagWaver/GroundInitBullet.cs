using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundInitBullet : MonoBehaviour
{
    [SerializeField]
    GameObject Obj;

    void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.tag == "Ground")
        {
            Instantiate(Obj, transform.position, Quaternion.identity);
        }
        Destroy(this.gameObject);
    }
}
