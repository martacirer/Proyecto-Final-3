using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.Rendering;

public class PostProcesadoManual : MonoBehaviour
{

    private Volume volume;
    private Timer timerscript;



    void Start()
    {
        volume = GetComponent<Volume>();
        timerscript = FindObjectOfType<Timer>();//Buscamos el script Timer
    }

    void Update()
    {
        if (timerscript.restante <= 10)//Cuando quedan 10 segundos se activa este efecto
        {
            if (volume.profile.TryGet<Bloom>(out var bloom))
            {
                bloom.active = true;
            }

        }
        else
        {
            if (volume.profile.TryGet<Bloom>(out var bloom))
            {
                bloom.active = false;
            }
        }

        if (timerscript.restante <= 5)//Cuando quedan 5 segundos se activa este efecto
        {
            if (volume.profile.TryGet<Vignette>(out var vignette))
            {
                vignette.active = true;
            }

        }
        else
        {
            if (volume.profile.TryGet<Vignette>(out var vignette))
            {
                vignette.active = false;
            }
        }
    }
}
