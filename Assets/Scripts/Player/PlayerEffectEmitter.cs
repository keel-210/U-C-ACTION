using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEffectEmitter : MonoBehaviour {
    public List<GameObject> effects = new List<GameObject>();
	public void Emit(PlayerEffectEnum EffeEnum)
    {
        switch (EffeEnum)
        {
        }
    }
}
public enum PlayerEffectEnum
{
    Test
}
