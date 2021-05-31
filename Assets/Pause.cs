using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public GameObject pauseMenu;

    public void pause()
    {
        Time.timeScale = 0;
            pauseMenu.gameObject.SetActive(true);
    }
}
