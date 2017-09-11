using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{
    [SerializeField]
    float ScrollSpeed;
    public int spriteCount = 3;

    Transform player;
    List<Renderer> rendList = new List<Renderer>();
    Vector3 spriteSize;
    float PosCash, direction = 1;
    void Start()
    {
        spriteSize = GetComponent<SpriteRenderer>().bounds.size;
        spriteCount = transform.parent.transform.childCount;
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void Update()
    {
        float offset = PosCash - player.position.x;
        if (offset > 0)
        {
            direction = -1;
        }
        else
        {
            direction = 1;
        }
        transform.position += Vector3.left * ScrollSpeed * -offset;
        PosCash = player.position.x;
    }
    void OnBecameInvisible()
    {
        transform.position += direction * Vector3.right * spriteSize.x * spriteCount;
    }
}
