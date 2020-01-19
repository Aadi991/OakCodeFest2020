using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLockLlo : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform reference;
    public float zpostion;
    public float lockrotationx = 0;
    public float lockrotationy = 0;
    public float lockrotationz = 0;


    
    void Update()
    {
        zpostion = reference.transform.rotation.z;
        zpostion = transform.position.z;
        lockrotationx = transform.rotation.x;
        lockrotationy = transform.rotation.y;
        lockrotationz = transform.rotation.z;


    }
}
