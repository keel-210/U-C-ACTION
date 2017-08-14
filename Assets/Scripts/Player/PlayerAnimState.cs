using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerAnimState : StateMachineBehaviour
{
    protected Rigidbody2D rb;
    protected PlayerController PC;
    protected AnimatorParameter.PlayerAnimator playeranimator = new AnimatorParameter.PlayerAnimator();

    Transform tra;
    private void Awake()
    {
        GameObject obj = GameObject.Find("Player");
        rb = obj.GetComponent<Rigidbody2D>();
        PC = obj.GetComponent<PlayerController>();
        tra = obj.transform;
        PlayerParamater PP = obj.GetComponent<PlayerParamater>();
        playeranimator.animator = PP.PlayerAnimator;
        playeranimator.Direction = 1;
    }
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        playeranimator.InStateTimer = 0;
        Enter(animator, stateInfo, layerIndex);
    }
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(Time.timeScale != 0)
        {
            playeranimator.Move = Input.GetAxisRaw("Horizontal");
            playeranimator.Moving = (Input.GetAxisRaw("Horizontal") != 0);
            playeranimator.Up = Input.GetAxisRaw("Vertical") == 1;
            playeranimator.Down = Input.GetAxisRaw("Vertical") == -1;
            playeranimator.Attack = Input.GetAxisRaw("Fire1") > 0;
            playeranimator.Attack2 = Input.GetAxisRaw("Fire2") > 0;
            playeranimator.Health = PC.health;
            playeranimator.InStateTimer += Time.deltaTime;
            if (playeranimator.Moving)
            {
                playeranimator.Direction = playeranimator.Move;
            }
            if (rb.velocity.y < 0 && (stateInfo.IsName("InAir") || stateInfo.IsName("FallAttack") || stateInfo.IsName("Rolling") || stateInfo.IsName("RollingAttack") || stateInfo.IsName("JumpRollingAttack")))
            {
                PC.ChangeLayer2Default();
            }
            Execute(animator, stateInfo, layerIndex);
        }
    }
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Exit(animator, stateInfo, layerIndex);
    }
    public virtual void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }
    public virtual void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }
    public virtual void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }
    public void DirectionFix()
    {
        tra.rotation = Quaternion.Euler(0, 90 * (playeranimator.Direction - 1), 0);
    }
}
