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
        Audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //disparar
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(projectilePrefab, transform.position, transform.rotation); // instanciar proyectil en una posición determinada
            Audio.PlayOneShot(shootClip, 1);

        }
    }
}
