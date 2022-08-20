using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private variables
    private float speed = 15.0f;
    private float turnSpeed = 30.0f;
    private float horizontalSpeed;
    private float verticalSpeed;
    private float xRange = 7.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get player input
        horizontalSpeed = Input.GetAxis("Horizontal");
        verticalSpeed = Input.GetAxis("Vertical");

        //preventing vehicle from falling off
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }


        //Will move vehicle forward / turn vehicle
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalSpeed);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalSpeed);
        
        
        
    }
}
