using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class OptionsScript : MonoBehaviour
{
    public GameObject optionsPanel;
    public TMP_InputField username;

    void Start()
    {
        //Obtiene las opciones guardadas
        LoadUserOptions();
    }
    public void SaveUserOptions()
    {
        //Persistencia de datos entre escenas
        DataPersistance.username = username.text;

        //Persistencia de datos entre partidas
        PlayerPrefs.SetString("USERNAME", username.text);
    }
    public void LoadUserOptions()
    {
        //Si tiene esta clave, tiene todas
        if (PlayerPrefs.HasKey("USERNAME"))
        {
            username.text = PlayerPrefs.GetString("USERNAME");

        }
    }
}
