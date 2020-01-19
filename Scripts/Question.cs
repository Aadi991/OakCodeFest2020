using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question : MonoBehaviour
{

    public PlayerMovement playerMovement;
    private void OnTriggerEnter(Collider other)
    {
        ShowQuestion();
        
    }
    void ShowQuestion()
    {

        
        
        
        Debug.Log("The question is showing");


    }
}
