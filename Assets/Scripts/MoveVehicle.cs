using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveVehicle : MonoBehaviour
{

    public float speed = 5;

    public bool directionIsForward = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var directionalspeed = Vector3.forward * speed * Time.deltaTime;

        if (directionIsForward)
        {
            transform.position += directionalspeed;
        }
        else
        {
            transform.position -= directionalspeed;
        }  
    }
}
