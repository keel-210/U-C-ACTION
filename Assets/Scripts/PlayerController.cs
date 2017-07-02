using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour, Health
{
    public float health { get; set; }

    [SerializeField]
    private AttackColliders _AC;
    public AttackColliders AC
    {
        get { return _AC; }
        set { _AC = value; }
    }
    public Rigidbody2D rb { get; set; }
    public AnimatorParameter.PlayerAnimator playeranimator { get; private set; }
    PlayerParamater pp;
    void Start ()
    {
        pp = GetComponent<PlayerParamater>();
        rb = GetComponent<Rigidbody2D>();
        playeranimator.animator = pp.PlayerAnimator;
	}
	
	void Update ()
    {
		
	}
}
