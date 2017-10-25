using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour, IDamasable, IEffectEmitter, IAttackColliders, IHitable
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
    public BoxCollider2D HitCollider;

    public PlayerParamater PP { get; set; }
    public bool HitStopped { get; set; }

    PlayerEffectEmitter PEE;
    string GroundTag = "Ground";
    Vector2 DefaultColliderSize;
    AnimatorParameter.PlayerAnimator playeranimator = new AnimatorParameter.PlayerAnimator();
    //Singleton
    private static GameObject _instance;
    public static GameObject instance
    {
        get { return _instance; }
    }
    private void Awake()
    {
        if (PlayerController.instance == null)
        {
            _instance = this.gameObject;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    //Costractor
    void Start()
    {
        PP = GetComponent<PlayerParamater>();
        playeranimator.animator = PP.PlayerAnimator;
        DefaultColliderSize = HitCollider.size;
        PEE = GetComponent<PlayerEffectEmitter>();
        DontDestroyOnLoad(this.gameObject);
    }
    private void OnLevelWasLoaded(int level)
    {
        transform.position = new Vector3(0, 0.1f, 0);
    }
    //4OnGround
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == GroundTag)
        {
            playeranimator.OnGround = true;
            playeranimator.HasDoubleJumped = false;
            playeranimator.DashAttacked = 0;
            playeranimator.JumpAttacked = false;
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
    //LayerChanging
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
    void ChangeLayer(GameObject obj, int LayerNumber)
    {
        obj.layer = LayerNumber;
    }
    //ColliderSizeChanging
    public void ChangeColliderSize(Vector2 size)
    {
        HitCollider.size = size;
    }
    public void ChangeColliderSize2Default()
    {
        HitCollider.size = DefaultColliderSize;
    }
    //IDamagable
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            GameObject.FindObjectOfType<MenuController>().GameOver();
        }
    }
    //IHittable
    public void Hit(Vector2 velo)
    {
        playeranimator.Hit = true;
    }
    //AttackEffect
    public void EffectEmit(int EffectEnum)
    {
        PEE.Emit((PlayerEffectEnum)EffectEnum);
    }
    //AttackCollider
    public void ColliderEnable(int ACEnum)
    {
        Colliders[ACEnum].SetActive(true);
    }
    public void ColliderUnable(int ACEnum)
    {
        Colliders[ACEnum].SetActive(false);
    }
    private void OnBecameInvisible()
    {
        
    }
    private void Update()
    {
        if (HitStopped)
        {
            StartCoroutine(this.DelayMethodByRealtime(0.1f, () =>
            {
                Time.timeScale = 1;
                HitStopped = false;
            }));
        }
    }
}
public enum PlayerAttackColliders
{ Attack1, Attack2, Attack3, JumpAttack, RollingAttack, FallAttack, AirAttack, DashAttack, SquatAttack, AirAttack2 }