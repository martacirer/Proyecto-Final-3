using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public GameObject projectilePrefab;
   


    // Update is called once per frame
    void Update()
    {
        //disparar
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(projectilePrefab, transform.position, transform.rotation);
        }
    }
}
