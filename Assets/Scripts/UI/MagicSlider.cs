using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagicSlider : MonoBehaviour
{
    PlayerController PP;
    Slider slider;

    void Start()
    {
        PP = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        slider = GetComponent<Slider>();
        slider.maxValue = 1000;
    }
    void Update()
    {
        if (PP)
        {
            PP = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
            slider.maxValue = 1000;
        }
        slider.value = PP.magic;
    }
}
