using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOutOfBounds : MonoBehaviour
{
    private float lowerBound = -25;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }else if (transform.position.y < lowerBound)
        {
            Destroy(gameObject);
        }
        
    }
}
