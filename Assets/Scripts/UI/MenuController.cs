using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MenuController : MonoBehaviour
{
    [SerializeField]
    List<GameObject> PauseObjs, GameOverObjs;

    float StartTimer = 0;
    bool Cancel,CancelCash,CancelPalse, IsPause;

    void Start()
    {
        PauseObjs.ForEach(go => go.SetActive(false));
        GameOverObjs.ForEach(go => go.SetActive(false));
    }

    void Update()
    {
        Cancel = Input.GetAxisRaw("Cancel") > 0;

        if (!Cancel)
        {
            CancelCash = Cancel;
        }
        CancelPalse = Cancel ^ CancelCash;

        if (CancelPalse)
        {
            if (IsPause)
            {
                MenuClose();
            }
            else
            {
                MenuOpen();
            }
        }
        if (Cancel)
        {
            CancelCash = Cancel;
        }
    }

    void MenuOpen()
    {
        if (Time.timeScale == 1)
        {
            IsPause = true;
            Time.timeScale = 0;
            PauseObjs.ForEach(go => go.SetActive(true));
        }
    }

    public void MenuClose()
    {
        IsPause = false;
        Time.timeScale = 1;
        PauseObjs.ForEach(go => go.SetActive(false));
    }

    public void GameOver()
    {
        GameOverObjs.ForEach(go => go.SetActive(true));
    }
}
