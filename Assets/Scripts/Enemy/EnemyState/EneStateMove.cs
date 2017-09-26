using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EneStateMove : EnemyAnimState
{
    [SerializeField]
    float Speed;
    [SerializeField]
    bool MovementFor2D;
    Vector2 dif;
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        float x = animator.GetFloat("PosDifX");
        float y = animator.GetFloat("PosDifY");
        dif = new Vector2(x, y);
        dif = dif.normalized;
        
        if(dif.x == 0 && dif.y == 0)
        {
            dif = Vector2.right;
        }
        if (dif.x > 0)
        {
            EC.Direction2Zero();
        }
        else
        {
            EC.Direction2Opposite();
        }
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (!EC.IsHit)
        {
            if (MovementFor2D)
            {
                rb.velocity = dif * -Speed;
            }
            else
            {
                rb.velocity = new Vector2(dif.x * -Speed, rb.velocity.y);
            }
        }
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }
}
