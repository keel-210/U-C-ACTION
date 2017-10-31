using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeCaller : MonoBehaviour
{

	void Start ()
    {
        Time.timeScale = 1;
        var list = FindObjectsOfType<Fade>();
        foreach(Fade f in list)
        {
            f.FadeOut(2f);
        }
	}
}
