using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelend : MonoBehaviour
{
    public GameObject end;
    public GameObject pause;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Time.timeScale = 0;
            end.gameObject.SetActive(true); //Makes the UI for end of the level activate when collided
            pause.gameObject.SetActive(false); //disables the pause object at the end
        }
    }
}
