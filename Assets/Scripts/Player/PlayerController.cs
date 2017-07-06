﻿using System.Collections;
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

    [SerializeField]
    Collider2D HitCollider;
    [SerializeField,Tag]
    string GroundTag;

    PlayerParamater pp;
    void Start ()
    {
        pp = GetComponent<PlayerParamater>();
        rb = GetComponent<Rigidbody2D>();
        Debug.Log(rb);
        playeranimator = new AnimatorParameter.PlayerAnimator();
        playeranimator.animator = pp.PlayerAnimator;
	}
	void Update ()
    {
        playeranimator.Move = Input.GetAxisRaw("Horizontal");
        playeranimator.Moving = (Input.GetAxisRaw("Horizontal") != 0);
        playeranimator.Up = Input.GetAxisRaw("Vertical") > 0;
        playeranimator.Down = Input.GetAxisRaw("Vertical") < 0;
        playeranimator.Attack = Input.GetAxisRaw("Fire1") > 0;
        playeranimator.Attack2 = Input.GetAxisRaw("Fire2") > 0;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == GroundTag)
        {
            playeranimator.OnGround = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == GroundTag)
        {
            playeranimator.OnGround = false;
        }
    }
    public void ChangeLayer2Invincible()
    {

    }
    public void ChangeLayer2Default()
    {

    }
    public void ChangeColliderSize4Squat(Vector2 size)
    {

    }
}
