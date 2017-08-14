using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ListActivater : MonoBehaviour
{
    [SerializeField]
    List<GameObject> Objs;
    private void Start()
    {
        Objs.ForEach(go => go.SetActive(false));
    }
    public virtual void Activate ()
    {
        Objs.ForEach(go => go.SetActive(true));
    }
}
