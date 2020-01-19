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
    public Rigidbody player;
    public Touch touch;
    public Vector3 touchPosition;
    public Camera maincamera;

    void Update()
    {




        if (Input.GetKeyDown(KeyCode.D))
        {
                Forward();
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            Backward();                                      

        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
                
            ForwardJump();

        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
                
            BackwardJump();

                

        }



        
            
      
    }

    public void Forward()
    {
        player.AddForce(forwards, ForceMode.VelocityChange);
        Debug.Log("Moved forward");

    }
    public void Backward()
    {
        player.AddForce(backwards, ForceMode.VelocityChange);
        Debug.Log("Moved backward");

    }
    public void BackwardJump()
    {
        player.AddForce(upbk, ForceMode.VelocityChange);
        Debug.Log("Jumped Backward");
    }
    public void ForwardJump()
    {
        player.AddForce(upfd, ForceMode.VelocityChange);
        Debug.Log("Jumped Forward");

    }








   
    
}
    

