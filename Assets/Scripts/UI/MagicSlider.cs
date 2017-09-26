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
    }
    void Update()
    {
        slider.value = PP.magic;
    }
}
