using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour, IDamasable, IEffectEmitter,IAttackColliders
{
    public int health { get; set; }

    [SerializeField]
    private List<GameObject> _Colliders;
    public List<GameObject> Colliders
    {
        get { return _Colliders; }
        set { _Colliders = value; }
    }
    [SerializeField]
    BoxCollider2D HitCollider;
    [SerializeField,Tag]
    string GroundTag;
    public PlayerParamater PP { get; set; }
    [SerializeField]
    PlayerEffectEmitter PEE;

    Vector2 DefaultColliderSize;
    AnimatorParameter.PlayerAnimator playeranimator = new AnimatorParameter.PlayerAnimator();

    void Start ()
    {
        PP = GetComponent<PlayerParamater>();
        playeranimator.animator = PP.PlayerAnimator;
        DefaultColliderSize = HitCollider.size;
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
    public void ChangeColliderSize(Vector2 size)
    {
        HitCollider.size = size;
    }
    public void ChangeColliderSize2Default()
    {
        HitCollider.size = DefaultColliderSize;
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
    }
    public void EffectEmit(int EffectEnum)
    {
        PEE.Emit((PlayerEffectEnum)EffectEnum);
    }
    public void ColliderEnable(int ACEnum)
    {
        Colliders[ACEnum].SetActive(true);
    }
    public void ColliderUnable(int ACEnum)
    {
        Colliders[ACEnum].SetActive(false);
    }
}
public enum PlayerAttackColliders
{ Attack1,Attack2,Attack3,JumpAttack,RollingAttack,FallAttack,AirAttack, DashAttack }