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
        SceneManager.LoadScene(NextScene);
    }
}
