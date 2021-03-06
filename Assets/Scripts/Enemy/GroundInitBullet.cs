﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundInitBullet : MonoBehaviour
{
    [SerializeField]
    GameObject Obj;
    [SerializeField]
    float BulletSpeed;
    [SerializeField]
    Vector3 rot;

    void Start()
    {
        StartCoroutine(this.DelayMethod(20f, () => { Destroy(gameObject); }));

        GetComponent<Rigidbody2D>().velocity = transform.up * BulletSpeed;
    }

    void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.tag == "Ground" && Obj)
        {
            Instantiate(Obj, transform.position, Quaternion.Euler(rot));
        }
        Destroy(this.gameObject);
    }
}
