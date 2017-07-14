using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerAnimState : StateMachineBehaviour
{
    protected Rigidbody2D rb;
    protected PlayerController PC;
    protected AnimatorParameter.PlayerAnimator playeranimator = new AnimatorParameter.PlayerAnimator();
    protected float Direction;

    Transform tra;
    private void Awake()
    {
        GameObject obj = GameObject.Find("Player");
        rb = obj.GetComponent<Rigidbody2D>();
        PC = obj.GetComponent<PlayerController>();
        tra = obj.transform;
        PlayerParamater PP = obj.GetComponent<PlayerParamater>();
        playeranimator.animator = PP.PlayerAnimator;
    }
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        playeranimator.InStateTimer = 0;
        Enter(animator, stateInfo, layerIndex);
    }
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        playeranimator.Move = Input.GetAxisRaw("Horizontal");
        playeranimator.Moving = (Input.GetAxisRaw("Horizontal") != 0);
        playeranimator.Up = Input.GetAxisRaw("Vertical") > 0;
        playeranimator.Down = Input.GetAxisRaw("Vertical") < 0;
        playeranimator.Attack = Input.GetAxisRaw("Fire1") > 0;
        playeranimator.Attack2 = Input.GetAxisRaw("Fire2") > 0;
        playeranimator.InStateTimer += Time.deltaTime;
        if (playeranimator.Move > 0)
        {
            tra.rotation = Quaternion.Euler(0, 0, 0);
            Direction = 1;
        }
        else if(playeranimator.Move < 0)
        {
            tra.rotation = Quaternion.Euler(0, 180, 0);
            Direction = -1;
        }
        Execute(animator, stateInfo, layerIndex);
    }
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Exit(animator, stateInfo, layerIndex);
    }
    public virtual void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }
    public virtual void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }
    public virtual void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }
}
