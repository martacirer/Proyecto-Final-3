
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverManager : MonoBehaviour
{
    public TextMeshProUGUI pointText;
    public static GameOverManager sharedInstance;
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
   
    public void ApplyOptions()
    {
        Debug.Log(DataPersistance.username);
        //Data persistance de las opciones
        username.text = DataPersistance.username;
        pointText.text = DataPersistance.score.ToString();

    }

}
