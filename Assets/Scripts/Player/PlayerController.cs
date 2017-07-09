using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour, Health, IDamasable, IEffectEmitter
{
    public float health { get; set; }

    [SerializeField]
    private AttackColliders _AC;
    public AttackColliders AC
    {
        get { return _AC; }
        set { _AC = value; }
    }

    [SerializeField]
    Collider2D HitCollider;
    [SerializeField,Tag]
    string GroundTag;
    public PlayerParamater PP { get; set; }
    [SerializeField]
    PlayerEffectEmitter PEE;

    AnimatorParameter.PlayerAnimator playeranimator = new AnimatorParameter.PlayerAnimator();

    void Start ()
    {
        PP = GetComponent<PlayerParamater>();
        playeranimator.animator = PP.PlayerAnimator;
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
        HitCollider.gameObject.layer = 10;
    }
    public void ChangeLayer2Default()
    {
        HitCollider.gameObject.layer = 9;
    }
    public void ChangeColliderSize4Squat(Vector2 size)
    {

    }
    public void TakeDamage(int damage)
    {

    }
    public void EffectEmit(int EffectEnum)
    {
        PEE.Emit((PlayerEffectEnum)EffectEnum);
    }
}
