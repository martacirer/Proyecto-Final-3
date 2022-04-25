using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectCollision : MonoBehaviour
{
    private void OnTriggerEnter (Collider otherCollider)
    {


        if (gameObject.CompareTag("Diana") && otherCollider.gameObject.CompareTag("proyectil"))
        {
            Destroy(otherCollider.gameObject);
            Destroy(gameObject);
        }
    }
}
