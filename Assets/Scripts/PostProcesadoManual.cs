using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.Rendering;

public class PostProcesadoManual : MonoBehaviour
{

    private Volume volume;
    private Timer timerscript;


    // Start is called before the first frame update
    void Start()
    {
        volume = GetComponent<Volume>();
        timerscript = FindObjectOfType<Timer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timerscript.restante <= 10)
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
        if (timerscript.restante <= 5)
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
