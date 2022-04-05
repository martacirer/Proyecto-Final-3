using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 500;

    private float xRotation;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInputMouse = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up  * horizontalInputMouse);

        float verticalInputMouse = Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;

        xRotation -= verticalInputMouse;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);






    }
}
