using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public GameObject projectilePrefab;
    private AudioSource Audio;
    public AudioClip shootClip;

    void Start()
    {
        //Obtenemos la componente Audio Source
        Audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        //Al pulsar click izquierdo
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(projectilePrefab, transform.position, transform.rotation); //Instanciar proyectil en una posición determinada
            Audio.PlayOneShot(shootClip, 1); //Reproducimos el audio de disparar

        }
    }
}
