using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class OptionsScript : MonoBehaviour
{
    public GameObject optionsPanel;
    public TMP_InputField username;
    // Start is called before the first frame update
    void Start()
    {
        LoadUserOptions();
    }
    public void SaveUserOptions()
    {
        //Persistencia de datos entre escenas
        DataPersistance.sharedInstance.username = username.text;

        //Persistencia de datos entre partidas
        DataPersistance.sharedInstance.SaveForFutureGames();
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
