using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateHit : StateMachineBehaviour
{
    [SerializeField]
    float _AnimateTime;
    public float AnimateTime
    {
        get { return _AnimateTime; }
        set { _AnimateTime = value; }
    }
    private PlayerController PC;
    private float Timer;
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC = animator.transform.root.GetComponent<PlayerController>();
        Timer = 0;
    }
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
}
