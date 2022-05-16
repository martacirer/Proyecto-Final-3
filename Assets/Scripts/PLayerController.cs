using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerController : MonoBehaviour
{

    

   

    public float speed = 10f;

    private float xRange = 16;
    private float yRange = 16;

    private Rigidbody playerRigidbody;


    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        //Cursor.lockState = CursorLockMode.None;
    }



    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        horizontalInput = Input.GetAxis("Horizontal");
        // movimiento horizontal del player
        playerRigidbody.AddForce(playerRigidbody.gameObject.transform.right * speed * horizontalInput);
       




        verticalInput = Input.GetAxis("Vertical");
        // movimiento vertical del player
        playerRigidbody.AddForce(playerRigidbody.gameObject.transform.forward * speed * verticalInput);
      
    }
}
