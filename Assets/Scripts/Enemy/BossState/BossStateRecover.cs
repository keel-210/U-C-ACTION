using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossStateRecover : EnemyAnimState
{
    [SerializeField]
    int RecoverLimit;
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.transform.root.gameObject.layer = 27;
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(EC.health < RecoverLimit)
        {
            EC.health += 5;
        }
        else
        {
            EC.health = RecoverLimit;
        }
        rb.position = new Vector2(rb.position.x, 4.2f);
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
}
