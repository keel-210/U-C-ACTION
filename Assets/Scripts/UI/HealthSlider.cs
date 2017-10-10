using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSlider : MonoBehaviour
{
    [SerializeField]
    GameObject obj;
    [SerializeField]
    bool IsPlayer;
    [SerializeField]
    float MaxValue, MinValue;

    Health health;
    Slider slider;

    void Start()
    {
        slider = GetComponent<Slider>();
        if (IsPlayer)
        {
            obj = GameObject.FindGameObjectWithTag("Player");
            health = obj.GetComponent<Health>();
            slider.maxValue = 1000;
        }
        else
        {
            health = obj.GetComponent<Health>();
            slider.maxValue = MaxValue - MinValue;
        }
        slider.value = health.health - MinValue;
    }

    void Update()
    {
        if (health != null && IsPlayer)
        {
            obj = GameObject.FindGameObjectWithTag("Player");
            slider = GetComponent<Slider>();
            health = obj.GetComponent<Health>();
            slider.maxValue = 1000;
            slider.value = health.health;
        }
        slider.value = health.health - MinValue;
    }
}
