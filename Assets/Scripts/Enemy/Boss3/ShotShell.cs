using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotShell : MonoBehaviour
{
    List<GameObject> objs = new List<GameObject>();
    int objsCount = 0;
    bool Activated;
	void Start ()
    {
        transform.rotation = Quaternion.identity;
        float i = 0;
		foreach(Transform x in transform)
        {
            objs.Add(x.gameObject);
            x.gameObject.SetActive(false);
            x.gameObject.GetComponent<MoveByCurve>().enabled = false;
            x.rotation = Quaternion.Euler(0, 0, i + (50 * Random.value));
            x.localPosition = 2 * x.up;
            i += 360/transform.childCount;
        }
    }
    private void Update()
    {
        if (!Activated)
        {
            shot();
        }
    }
    void shot ()
    {
        if (objsCount < transform.childCount -1)
        {
            StartCoroutine(this.DelayMethod(1 / transform.childCount, () =>
            {
                objs[objsCount].SetActive(true);
                objsCount++;
            }));
        }
        else
        {
            foreach (Transform x in transform)
            {
                x.gameObject.GetComponent<MoveByCurve>().enabled = true;
            }
            Activated = true;
        }
	}
}
