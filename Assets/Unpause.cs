using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unpause : MonoBehaviour
{
    public GameObject pauseMenu;

    public void unPause()
    {
        Time.timeScale = 1;
        pauseMenu.gameObject.SetActive(false);
    }
}
