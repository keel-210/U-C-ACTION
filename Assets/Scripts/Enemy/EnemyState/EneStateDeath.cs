using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EneStateDeath : EnemyAnimState
{
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        EC.ChangeLayer2Default();
        if (EC.Drop)
        {
            int DropNum = Random.Range(EC.DropMin, EC.DropMax);
            for (int i = 0; i < DropNum; i++)
            {
                Instantiate(EC.Drop, tra.position + new Vector3(Random.value, Random.value, 0), Quaternion.identity);
            }
        }
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb.velocity = Vector2.Lerp(rb.velocity, Vector2.zero, 0.1f);
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
}
