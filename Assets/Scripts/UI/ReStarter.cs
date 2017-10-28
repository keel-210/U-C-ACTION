using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReStarter : MonoBehaviour
{
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            FindObjectOfType<PlayerController>().ReStarter();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
	}
}
