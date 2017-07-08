using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerAnimState : StateMachineBehaviour
{
    protected Rigidbody2D rb;
    protected PlayerController PC;
    protected AnimatorParameter.PlayerAnimator playeranimator = new AnimatorParameter.PlayerAnimator();
    private void Awake()
    {
        GameObject obj = GameObject.Find("Player");
        rb = obj.GetComponent<Rigidbody2D>();
        PC = obj.GetComponent<PlayerController>();
        PlayerParamater pp = obj.GetComponent<PlayerParamater>();
        playeranimator.animator = pp.PlayerAnimator;
    }
}
