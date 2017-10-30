using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField, SceneName]
    string NextScene;

    public void Change()
    {
        Fade[] fadeArray = FindObjectsOfType<Fade>();
        foreach(Fade f in fadeArray)
        {
            f.FadeIn(2f, () =>
            {
                SceneManager.LoadScene(NextScene);
            });
        }
    }
}
