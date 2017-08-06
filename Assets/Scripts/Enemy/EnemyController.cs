using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyController : MonoBehaviour,IAttackColliders, IDamasable,IHitable
{
    [SerializeField]
    protected int _health;
    public int health { get { return _health; } set { _health = value; } }
    [SerializeField]
    protected List<GameObject> _Colliders;
    public List<GameObject> Colliders
    {
        get { return _Colliders; }
        set { _Colliders = value; }
    }
    protected Rigidbody2D rb;
    protected float Direction;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void Direction2Zero()
    {
        transform.rotation = Quaternion.Euler(0, 0, 0);
        Direction = 1;
    }
    public void Direction2Opposite()
    {
        transform.rotation = Quaternion.Euler(0, 180, 0);
        Direction = -1;
    }
    public void ColliderEnable(int ACEnum)
    {
        Colliders[ACEnum].SetActive(true);
    }
    public void ColliderUnable(int ACEnum)
    {
        Colliders[ACEnum].SetActive(false);
    }
    public virtual void TakeDamage(int damage) { }
    public virtual void Hit(Vector2 velo) { }
}
