using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBuilding : MonoBehaviour
{
    private GameManager GameManagerScript;
    void Start()
    {
        GameManagerScript = FindObjectOfType<GameManager>(); // encuentra el script
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.gameObject.CompareTag("proyectil"))
        {
            
            Destroy(otherCollider.gameObject);// destruye objecto cuando choca

        }
    }
}
