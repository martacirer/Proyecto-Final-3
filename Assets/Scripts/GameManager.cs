
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI pointText;
    public int Score = 0;


    public void contador()
    {
        Score++; // suma 1
        pointText.text = $"Score: {Score}";// puntuación
    }

}
