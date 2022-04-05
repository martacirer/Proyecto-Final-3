using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerController : MonoBehaviour
{

    

    private float horizontalInput;
    private float verticalInput;

    public float speed = 10f;

    private float xRange = 16;
    private float yRange = 16;


    void Start()
    {
        
    }


    void Update()
    {
       
        horizontalInput = Input.GetAxis("Horizontal");

        // movimiento horizontal del player
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);

        // limite de pantalla derecho (que lo determina xRange)
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y,
                transform.position.z);
        }

        // limite pantalla izquierdo
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y,
                transform.position.z);
        }

        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);

        if (transform.position.y > yRange)
        {
            transform.position = new Vector3(transform.position.x, yRange,
                transform.position.z);
        }

        // limite pantalla izquierdo
        if (transform.position.y < -yRange)
        {
            transform.position = new Vector3(transform.position.x, -yRange,
                transform.position.z);
        }

    }
}
