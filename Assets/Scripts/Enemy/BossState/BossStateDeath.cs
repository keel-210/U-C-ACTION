using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossStateDeath : EnemyAnimState
{
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool("Death", true);
        EC.ChangeLayer2Default();
        FindObjectOfType<MenuController4Boss>().Clear();
        GameObject.FindGameObjectWithTag("GameController").GetComponent<BoxCollider2D>().enabled = true;
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
}
