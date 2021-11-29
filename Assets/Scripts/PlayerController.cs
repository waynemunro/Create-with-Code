using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnspeed = 45f;
    private float horizontalInput;
    private float forwardInput;

    // Update is called once per frame
    private void Update()
    {
        // this is where we get player imput
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // We'll move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // we turn the vehicle
        transform.Rotate(Vector3.up * Time.deltaTime * turnspeed * horizontalInput);
    }
}
