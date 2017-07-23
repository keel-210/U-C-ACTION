using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHitable
{
    Vector2 HitVelo { get; set; }
    void Hit(Vector2 HitVelo);
}
