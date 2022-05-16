using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class detectCollision : MonoBehaviour
{

    private GameManager GameManagerScript;
    public ParticleSystem explosionParticleSystem;

    private void Start()
    {
        GameManagerScript = FindObjectOfType<GameManager>(); // encuentra el script

    }
    private void OnTriggerEnter (Collider otherCollider)
    {


        if (otherCollider.gameObject.CompareTag("proyectil"))
        {
            float d = Vector3.Distance(otherCollider.gameObject.transform.position, 
                transform.position); //calcula distancia entre bala y centro de diana
            //Debug.Log(d);
            //Debug.Log(otherCollider.gameObject.transform.position);// calcula posicion del gameoibject
            //Debug.Log(GetComponent<BoxCollider>().center); // calcula centro del boxcollider
            Destroy(otherCollider.gameObject);// destruye objecto cuando choca
            Destroy(gameObject);// destruye objecto
            Debug.Log($"+1"); // cuando choca suma 1
            GameManagerScript.contador();// accede al contador del scrpit GameManager
            Instantiate(explosionParticleSystem,
                transform.position,
                explosionParticleSystem.transform.rotation);
        }
    }
}
