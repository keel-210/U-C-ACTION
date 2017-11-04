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
        Debug.Log(GameObject.FindGameObjectWithTag("GameController"), GameObject.FindGameObjectWithTag("GameController"));
        GameObject.FindGameObjectWithTag("GameController").GetComponent<BoxCollider2D>().enabled = true;
        if (EC.Drop)
        {
            int DropNum = Random.Range(EC.DropMin, EC.DropMax);
            for (int i = 0; i < DropNum; i++)
            {
                Instantiate(EC.Drop, tra.position + new Vector3(5*Random.value, 5*Random.value, 0), Quaternion.identity);
            }
        }
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
}
