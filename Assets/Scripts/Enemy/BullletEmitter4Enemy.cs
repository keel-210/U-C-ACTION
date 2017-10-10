using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullletEmitter4Enemy : MonoBehaviour
{
    [SerializeField]
    Object bullet;
    private void OnEnable()
    {
        Instantiate(bullet, transform.position, transform.rotation);
    }
}
