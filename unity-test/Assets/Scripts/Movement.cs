using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    private float xRotation;

    private float zMovement;
    private float xMovement;

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


        //Movement
        zMovement = Input.GetAxis("Vertical");
        xMovement = Input.GetAxis("CHorizontal");

        Vector3 zCam = transform.forward;
        Vector3 xCam = transform.right;


        //Makes it so that y values get reset (the y rotation of the camera won't impact the direction)
        zCam.y = 0;
        xCam.y = 0;

        //Not sure what this actually does, but the tutorial I looked at said it was necessary
        xCam = xCam.normalized;
        zCam = zCam.normalized;


        //strafing is slower than moving forward (mimicing real life mecanum)
        transform.position += (zMovement * zCam * speed + xMovement * xCam * speed / 1.5F) * Time.deltaTime;
    }
}
