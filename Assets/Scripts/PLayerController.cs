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
        Cursor.lockState = CursorLockMode.Locked;
        //Cursor.lockState = CursorLockMode.None;
    }


    void Update()
    {
        
        horizontalInput = Input.GetAxis("Horizontal");
        // movimiento horizontal del player
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);

    

        verticalInput = Input.GetAxis("Vertical");
        // movimiento vertical del player
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
      
    }
}
