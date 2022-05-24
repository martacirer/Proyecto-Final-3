
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI pointText;
    public int Score = 0;

    public static GameManager sharedInstance;
    public TextMeshProUGUI username;

    private void Awake()
    {

        if (sharedInstance == null)
        {
            sharedInstance = this;
        }
        else
        {
            //Si ya existe una instancia, se destruye
            Destroy(this);
        }
    }
    void Start()
    {
        //Aplicamos las opciones que hemos cambiado en el menu
        ApplyOptions();
    }
    public void contador()
    {
        Score++; // suma 1
        pointText.text = $"Score: {Score}";// puntuación
    }
    public void ApplyOptions()
    {
        //Data persistance de las opiones
        username.text = DataPersistance.sharedInstance.username;

    }

}
