using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alpha4Init : MonoBehaviour
{
    Renderer ren;
    [SerializeField]
    float alpha;
    Color offset;
	void Start ()
    {
        ren = GetComponent<Renderer>();
        Color c = ren.material.color;
        ren.material.color = new Color(c.r, c.g, c.b, 0);
        offset = new Color(0, 0, 0, alpha);
	}
	void Update ()
    {
		if(ren.material.color.a < 1)
        {
            ren.material.color += offset;
        }
	}
}
