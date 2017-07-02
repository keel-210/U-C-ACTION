using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateRollingAttack : StateMachineBehaviour
{
    [SerializeField]
    Vector2 _velo;
    public Vector2 velo
    {
        get { return _velo; }
        set { _velo = value; }
    }
    private PlayerController PC;
    float dir;
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC = animator.transform.root.GetComponent<PlayerController>();
        PC.gameObject.layer = 10;
    }
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC.rb.velocity += new Vector2(velo.x * dir, PC.rb.gravityScale * velo.y);
        PC.gameObject.layer = 10;
    }
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC.gameObject.layer = 9;
    }
}
