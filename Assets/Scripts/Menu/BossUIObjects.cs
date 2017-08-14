using UnityEngine;
using System.Collections;

public class BossUIObjects : ListActivater
{
    private void Awake()
    {
        this.Activate();
    }
    public override void Activate()
    {
        Time.timeScale = 0;
        base.Activate();
    }
}
