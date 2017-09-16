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

    Health health;
    Slider slider;

	void Start ()
    {
        if (IsPlayer)
        {
            obj = GameObject.FindGameObjectWithTag("Player");
        }
        slider = GetComponent<Slider>();
        health = obj.GetComponent<Health>();
	}
	void Update()
    {
        slider.value = health.health;
    }
}
