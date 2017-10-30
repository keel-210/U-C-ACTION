using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MPDrop : MonoBehaviour
{
    [SerializeField]
    int magic;
    [SerializeField]
    Object effect;
    private void Start()
    {
        GetComponent<PlayerChaser>().enabled = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.transform.root.GetComponent<PlayerController>().magic += magic;
        if (effect)
        {
            Instantiate(effect, collision.contacts[0].point, transform.rotation);
        }
        Destroy(gameObject);
    }
}
