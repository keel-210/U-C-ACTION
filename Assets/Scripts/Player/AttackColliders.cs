using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAttackColliders
{
    List<GameObject> Colliders { get; set; }
    void ColliderEnable(int ACEnum);
    void ColliderUnable(int ACEnum);
}
