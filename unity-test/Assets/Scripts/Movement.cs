using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    private static float xMovement;
    private static float zMovement;
    Vector3 movement;

    /*
    // Start is called before the first frame update
    void Start() {
        
    }
    */

    // Update is called once per frame
    void Update() {
        xMovement = Input.GetAxis("Horizontal");
        zMovement = Input.GetAxis("Vertical");

        movement = new Vector3(xMovement, 0, zMovement);
        transform.position += movement * Time.deltaTime;
    }
}
