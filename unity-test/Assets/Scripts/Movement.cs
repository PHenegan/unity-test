using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    private float xRotation;

    private float zMovement;
    private Vector3 movement;

    public float speed = 5;
    public float rotationSpeed = 90;

    //Not sure what this actually does, I copied it from a tutorial
    public float heading = 0;

    /*
    // Start is called before the first frame update
    void Start() {
        
    }
    */

    // Update is called once per frame
    void Update() {

        //Rotating the object left and right(A/D)
        heading += Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        //Really not sure what this does at all
        transform.rotation = Quaternion.Euler(0, heading, 0);


        //Moving morward and backward (W/S)
        zMovement = Input.GetAxis("Vertical");
        xMovement = Input.GetAxis();
        Vector3 direction = transform.forward;


        //Makes it so that y values get reset (the y rotation of the camera won't impact the direction)
        direction.y = 0;

        //Not sure what this actually does, but the tutorial I looked at said it was necessary
        direction = direction.normalized;


        transform.position += (zMovement * direction) * Time.deltaTime * speed;
        //transform.position += movement * Time.deltaTime;
    }
}
