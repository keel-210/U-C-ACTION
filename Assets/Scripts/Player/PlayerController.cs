using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour, Health, IDamasable
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
    public PlayerParamater PP { get; set; }
    [SerializeField]
    PlayerEffectEmitter PEE;
    void Start ()
    {
        PP = GetComponent<PlayerParamater>();
        rb = GetComponent<Rigidbody2D>();
        playeranimator = new AnimatorParameter.PlayerAnimator();
        playeranimator.animator = PP.PlayerAnimator;
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
    public void EffectEmit(PlayerEffectEnum EffeEnum)
    {
        PEE.Emit(EffeEnum);
    }
}
