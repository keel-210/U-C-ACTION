using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alpha4UI : MonoBehaviour
{
    [SerializeField]
    float alpha, DefaultAlpha;

    CanvasRenderer rend;
    void Awake()
    {
        rend = GetComponent<CanvasRenderer>();
    }
    void OnEnable()
    {
        rend.SetAlpha(DefaultAlpha);
    }
    void Update()
    {
        if (rend.GetAlpha() <= 1 && rend.GetAlpha() >= 0)
        {
            rend.SetAlpha(rend.GetAlpha() + alpha);
        }
    }
}
