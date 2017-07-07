using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimState : StateMachineBehaviour
{
    protected Rigidbody2D rb;
    protected PlayerController pc;
    private void Awake()
    {
        GameObject obj = GameObject.Find("Player");
        rb = obj.GetComponent<Rigidbody2D>();
        pc = obj.GetComponent<PlayerController>();
    }
}
