using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerParamater : MonoBehaviour
{
    [SerializeField]
    private Animator _PlayerAnimator;
    public Animator PlayerAnimator
    {
        get { return _PlayerAnimator; }
        set { _PlayerAnimator = value; }
    }
    [SerializeField]
    float Speed, JumpPower, SecondJumpPower, GlidePower;
	void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}
}
