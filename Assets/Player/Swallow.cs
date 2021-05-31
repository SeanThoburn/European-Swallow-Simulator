using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swallow : MonoBehaviour
{
    public Rigidbody2D body;
    public float flappyh; //horizontal speed
    public float flappyv; //vertical speed
    public GameObject fail;
    public GameObject pause;
    

    public float forwardspeed;
    public float movespeed;
    Vector2 movement;
    //Last 3 are all for the moving to the right

    private void FixedUpdate()
    {
        body.AddForce(new Vector2(Input.GetAxis("Horizontal") * flappyh, Input.GetAxis("Vertical") * flappyv)); //Bird movement, probably can do it more efficiently as I only need vertical axis but get the game to play properly first
        body.MovePosition(body.position + new Vector2(forwardspeed * Time.fixedDeltaTime, movement.y * movespeed * Time.fixedDeltaTime)); //Makes the bird move to the right constantly
    }
    private void OnCollisionEnter2D(Collision2D collision) //activates the failure if the player collides with tagged hazardous objects
    {
        if (collision.gameObject.tag == "Hazard")
        {
            Time.timeScale = 0;
            fail.gameObject.SetActive(true); //this will bring up the screen to retry the mission when you collide with a hazardous object.
            pause.gameObject.SetActive(false); //disables the pause object at the end
        }
    }
}
