using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReStarter : MonoBehaviour
{
	void Update ()
    {
        if (Input.GetAxisRaw("Fire3") > 0)
        {
            FindObjectOfType<PlayerController>().ReStarter();
            Time.timeScale = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
	}
}
