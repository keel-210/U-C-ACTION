﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChangerCaller : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<SceneChanger>().Change();
    }
}
