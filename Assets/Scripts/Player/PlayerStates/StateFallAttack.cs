using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateFallAttack : StateMachineBehaviour
{
    [SerializeField]
    Vector2 _vec;
    public Vector2 vec
    {
        get { return _vec; }
        set { _vec = value; }
    }
    private PlayerController PC;
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC = animator.transform.parent.GetComponent<PlayerController>();
        PC.gameObject.layer = 13;
    }
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC.rb.velocity += vec;
        PC.gameObject.layer = 13;
    }
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC.gameObject.layer = 9;
    }
}
