using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    private float xMovement;
    private float zMovement;
    private Vector3 movement;

    public Transform camera;

    /*
    // Start is called before the first frame update
    void Start() {
        
    }
    */

    // Update is called once per frame
    void Update() {
        xMovement = Input.GetAxis("Horizontal");
        zMovement = Input.GetAxis("Vertical");

        //movement = new Vector3(xMovement, 0, zMovement);

        Vector3 camZ = camera.forward;
        Vector3 camX = camera.right;


        transform.position += (zMovement * camZ + xMovement * camX) * Time.deltaTime;
        //transform.position += movement * Time.deltaTime;
    }
}
