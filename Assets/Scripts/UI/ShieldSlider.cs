using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldSlider : MonoBehaviour
{
    [SerializeField]
    GameObject obj;

    Slider slider;
    IShield shield;
    void Start()
    {
        slider = GetComponent<Slider>();
        shield = obj.GetComponent<IShield>();
        slider.maxValue = shield.Shield;
    }
    void Update()
    {
        slider.value = shield.Shield;
    }
}
