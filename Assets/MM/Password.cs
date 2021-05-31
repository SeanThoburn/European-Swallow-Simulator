using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Password : MonoBehaviour
{
    public InputField password;
    public string levelOne;
    public string levelTwo;
    public string levelThree;
    public string levelThreeTwo;
    public string levelFour;
    public string levelFive;
    public string levelSix;
    public string test;

    public void passwordcheck()
    {
        if (password.text.ToString() == levelOne)
        {
            SceneManager.LoadScene("lv1");
        }
        if (password.text.ToString() == levelTwo)
        {
            SceneManager.LoadScene("lv2");
        }
        if (password.text.ToString() == levelThree)
        {
            SceneManager.LoadScene("lv3");
        }
        if (password.text.ToString() == levelThreeTwo)
        {
            SceneManager.LoadScene("lv32");
        }
        if (password.text.ToString() == levelFour)
        {
            SceneManager.LoadScene("lv4");
        }
        if (password.text.ToString() == levelFive)
        {
            SceneManager.LoadScene("lv5");
        }
        if (password.text.ToString() == levelSix)
        {
            SceneManager.LoadScene("lv6");
        }
        if (password.text.ToString() == test)
        {
            SceneManager.LoadScene("test");
        }

    }
}
