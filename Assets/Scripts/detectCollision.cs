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
            //Dependiendo de la distancia de la bala al centro de la diana, se sumaran diferentes puntos
            if (d < 0.5f)
            {
                GameManager.sharedInstance.contador(3);
            }
            else if(d< 0.75f)
            {
                GameManager.sharedInstance.contador(2);
            }
            else
            {
                GameManager.sharedInstance.contador(1);
            }
            Destroy(otherCollider.gameObject);//Destruye objecto cuando choca
            Destroy(gameObject);//Destruye objecto
            Debug.Log($"+1"); //Cuando choca suma 1
            Instantiate(explosionParticleSystem,
                transform.position,
                explosionParticleSystem.transform.rotation); //Se instancian las particulas
        }
    }
}
