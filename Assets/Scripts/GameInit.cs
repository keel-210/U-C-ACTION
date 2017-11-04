using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInit
{
    [RuntimeInitializeOnLoadMethod]
    static void OnRuntimeMethodLoad()
    {
        Screen.SetResolution(1600,900, true, 60);

    }
}
