using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    [SerializeField] int min, seg;
    [SerializeField] Text tiempo;


    public float restante;
    private bool enMarcha;
    private void Awake()
    {
        //Al empezar se pone en marcha el contador con el tiempo establecido
        restante = (min * 60) + seg;
        enMarcha = true;
    }

    private void Update()
    {                 //cuenta atrás
        if (enMarcha)
        {
            restante -= Time.deltaTime;
            if (restante < 1)
            {
                enMarcha = false;//Se para el contador
                Cursor.lockState = CursorLockMode.None;//Se muestra el raton 
                GameManager.sharedInstance.saveContador();//Se guarda el contador para el script gameManager
                SceneManager.LoadScene("Gameover");//Cargamos la escena Gameover
            }
        }
        //Cada minuto son 60 segundos 
        int tempMin = Mathf.FloorToInt(restante / 60);
        int tempSeg = Mathf.FloorToInt(restante % 60);
        //El formato es en minutos y segundos: "00:00"
        tiempo.text = string.Format("{00:00}:{01:00}", tempMin, tempSeg);
    }
}
