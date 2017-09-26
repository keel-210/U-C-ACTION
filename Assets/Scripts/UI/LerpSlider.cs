using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LerpSlider : MonoBehaviour
{
    [SerializeField]
    Slider TargetSlider;
    [SerializeField]
    float ratio;

    Slider slider;

    void Start()
    {
        slider = GetComponent<Slider>();
        slider.maxValue = TargetSlider.maxValue;
        slider.value = slider.maxValue;
    }
    void Update()
    {
        slider.value = (int)Mathf.Lerp(slider.value, TargetSlider.value, ratio);
    }
}
