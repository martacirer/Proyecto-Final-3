using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBuilding : MonoBehaviour
{
    private GameManager GameManagerScript;
    void Start()
    {
        GameManagerScript = FindObjectOfType<GameManager>(); //Encuentra el script Game Manager
    }

    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.gameObject.CompareTag("proyectil"))
        {
            
            Destroy(otherCollider.gameObject);//Destruye objecto cuando choca

        }
    }
}
