using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{
    public Rigidbody2D body;
    public float forwardspeed;
    public float movespeed;
    Vector2 movement;

    private void FixedUpdate()
    {
        body.MovePosition(body.position + new Vector2(forwardspeed * Time.fixedDeltaTime, movement.y * movespeed * Time.fixedDeltaTime)); //Moves the camera right to follow the bird without having it match the vertical of the bird
    }
}
