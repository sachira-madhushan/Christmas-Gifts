using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class HighScore : MonoBehaviour
{
    public TextMeshProUGUI highScore;
    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 000).ToString();
    }
}
