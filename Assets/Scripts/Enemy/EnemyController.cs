using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour, IDamasable, Health
{
    public float health { get; set; }
    void Start () {
		
	}
	
	void Update () {
		
	}
    public void TakeDamage(int damage)
    {

    }
}
