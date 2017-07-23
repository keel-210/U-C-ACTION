using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour, IDamasable, IEffectEmitter,IAttackColliders
{
    [SerializeField]
    int _health;
    public int health
    {
        get { return _health; }
        set { _health = value; }
    }
    [SerializeField]
    private int _magic;
    public int magic
    {
        get { return _magic; }
        set { _magic = value; }
    }
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
        if(collision.gameObject.tag == GroundTag)
        {
            playeranimator.OnGround = true;
            playeranimator.HasDoubleJumped = false;
            playeranimator.DashAttacked = 0;
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == GroundTag && !playeranimator.OnGround)
        {
            playeranimator.OnGround = true;
            playeranimator.HasDoubleJumped = false;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == GroundTag)
        {
            playeranimator.OnGround = false;
            playeranimator.HasDoubleJumped = false;
            ChangeLayer2Squat();
        }
    }
    public void ChangeLayer2Invincible()
    {
        ChangeLayer(HitCollider.gameObject, 9);
    }
    public void ChangeLayer2Default()
    {
        ChangeLayer(HitCollider.gameObject, 8);
        ChangeLayer(gameObject, 15);
    }
    public void ChangeLayer2Squat()
    {
        ChangeLayer(gameObject, 16);
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
    void ChangeLayer(GameObject obj,int LayerNumber)
    {
        obj.layer = LayerNumber;
    }
}
public enum PlayerAttackColliders
{ Attack1,Attack2,Attack3,JumpAttack,RollingAttack,FallAttack,AirAttack, DashAttack,SquatAttack }