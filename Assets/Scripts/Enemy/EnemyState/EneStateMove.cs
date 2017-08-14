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
        if (MovementFor2D)
        {
            dif = new Vector2(x, y);
        }
        else
        {
            dif = new Vector2(dif.x, 0);
            if(dif.x == 0)
            {
                dif = new Vector2(1, 0);
            }
        }
        dif = dif.normalized;
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
            rb.velocity = dif * -Speed;
        }
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }
}
