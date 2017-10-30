using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPDrop : MonoBehaviour
{
    [SerializeField]
    int health;
    [SerializeField]
    Object effect;

    bool HasCollided;
    private void Start()
    {
        GetComponent<PlayerChaser>().enabled = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.transform.root.GetComponent<PlayerController>().health += health;
        if (effect)
        {
            Instantiate(effect, collision.contacts[0].point, transform.rotation);
        }
        Destroy(gameObject);
    }
}
