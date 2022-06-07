using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class optionsmenu : MonoBehaviour
{
    public void GoToMainScene()
    {
        //Carga la escena principal
        SceneManager.LoadScene("Main Menu");
    }
}
