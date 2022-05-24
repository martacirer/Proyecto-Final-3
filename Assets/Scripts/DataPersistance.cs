using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPersistance : MonoBehaviour
{
    public static DataPersistance sharedInstance;
    //Delaramos Variables. Nos serviran para conservar los valores entre escenas
    public string username;
    // Start is called before the first frame update
    private void Awake()
    {
        //Hacemos que si no existe una instancia...
        if (sharedInstance == null)
        {
            sharedInstance = this;
            //...no sea destruida al cambiar la escena
            DontDestroyOnLoad(sharedInstance);
        }
        else
        {
            //Si ya existe una instancia, se destruye
            Destroy(this);
        }
    }
    public void SaveForFutureGames()
    {
        //El nombre del player
        PlayerPrefs.SetString("USERNAME", username);

    }
}
