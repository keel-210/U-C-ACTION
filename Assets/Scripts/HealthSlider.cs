using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSlider : MonoBehaviour
{
    [SerializeField]
    GameObject obj;
    Health health;
    Slider slider;
	void Start ()
    {
        slider = GetComponent<Slider>();
        health = obj.GetComponent<Health>();
	}
	void Update()
    {
        slider.value = health.health;
    }
}
