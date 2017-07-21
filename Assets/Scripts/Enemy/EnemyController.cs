using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyController : MonoBehaviour,IAttackColliders, IDamasable
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
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void ColliderEnable(int ACEnum)
    {
        Colliders[ACEnum].SetActive(true);
    }
    public void ColliderUnable(int ACEnum)
    {
        Colliders[ACEnum].SetActive(false);
    }
    public virtual void TakeDamage(int damage)
    {
        
    }
}
