using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back2Title : MonoBehaviour
{
	void Update ()
    {
        if (Input.GetAxisRaw("Jump")>0)
        {
            Destroy(GameObject.FindGameObjectWithTag("Player"));
            SceneManager.LoadScene(0);
        }
	}
}
