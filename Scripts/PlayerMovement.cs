using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public Vector2 forwards = new Vector2(25, 0);
    public Vector2 backwards = new Vector2(-25, 0);
    public Vector2 upfd = new Vector2(25, 25);
    public Vector2 upbk = new Vector2(-25, 25);
    public Rigidbody2D player;

    public void Forward()
    {
        player.AddForce(forwards);
        Debug.Log("Moved forward");

    }
    public void Backward()
    {
        player.AddForce(backwards);
        Debug.Log("Moved backward");

    }
    public void BackwardJump()
    {
        player.AddForce(upbk);
        Debug.Log("Jumped Backward");
    }
    public void ForwardJump()
    {
        player.AddForce(upfd);
        Debug.Log("Jumped Forward");

    }








   
    
}
    

