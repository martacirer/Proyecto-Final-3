using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public void GoToScene(string sceneName)
    {
        //Cargamos la escena que tenga por nombre sceneName
        SceneManager.LoadScene(sceneName);
    }

    public void Quit()
    {
        //Si estamos haciendo pruebas en el editor

        //Salimos del editor
        UnityEditor.EditorApplication.isPlaying = false;

        //Salimos de la aplicación (solo funcionará en la Build)
        Application.Quit();
    }
}
