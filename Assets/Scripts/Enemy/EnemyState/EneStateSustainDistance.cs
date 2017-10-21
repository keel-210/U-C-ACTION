using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EneStateSustainDistance : EnemyAnimState
{
    [SerializeField]
    Vector2 offset;
    [SerializeField]
    float Speed;
    [SerializeField]
    bool DisableX, DisableY, DontFixDirection;

    Vector2 realOffset;

    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Vector2 dif = new Vector2(animator.GetFloat("PosDifX"), animator.GetFloat("PosDifY"));
        if (dif.x > 0)
        {
            realOffset = offset - dif;
        }
        else
        {
            realOffset = new Vector2(-offset.x, offset.y) - dif;
        }
        if (!DontFixDirection)
        {
            if (realOffset.x > 0)
            {
                EC.Direction2Opposite();
            }
            else
            {
                EC.Direction2Zero();
            }
        }
        if (DisableX)
        {
            realOffset = new Vector2(0, realOffset.y);
        }
        if (DisableY)
        {
            realOffset = new Vector2(realOffset.x, 0);
        }
        if (Mathf.Abs(dif.x) < 0.1f && Mathf.Abs(dif.y) < 0.1f)
        {
            rb.velocity = Vector2.zero;
        }
        else
        {
            rb.velocity =Vector2.Lerp(rb.velocity, realOffset.normalized * Speed,0.05f);
        }
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb.velocity = Vector2.zero;
    }
}
