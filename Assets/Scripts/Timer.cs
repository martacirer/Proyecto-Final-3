﻿using System.Collections;
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
                enMarcha = false;
                Debug.Log("game over");
                Cursor.lockState = CursorLockMode.None;
                GameManager.sharedInstance.saveContador();
                SceneManager.LoadScene("Gameover");
                //matar el player
            }
        }
        int tempMin = Mathf.FloorToInt(restante / 60);
        int tempSeg = Mathf.FloorToInt(restante % 60);
        tiempo.text = string.Format("{00:00}:{01:00}", tempMin, tempSeg);
    }
}
