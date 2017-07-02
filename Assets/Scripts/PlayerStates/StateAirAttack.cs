
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateAirAttack : StateMachineBehaviour
{
    [SerializeField]
    float _AnimateTime;
    public float AnimateTime
    {
        get { return _AnimateTime; }
        set { _AnimateTime = value; }
    }
    [SerializeField]
    float _ActivateTime;
    public float ActivateTime
    {
        get { return _ActivateTime; }
        set { _ActivateTime = value; }
    }
    [SerializeField]
    Vector2 _velo;
    public Vector2 velo
    {
        get { return _velo; }
        set { _velo = value; }
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
        PC.rb.velocity = velo;
        Timer += Time.deltaTime;
        if (Timer < AnimateTime)
        {
        }
        else
        {
        }
    }
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
}
