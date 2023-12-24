using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Win : MonoBehaviour
{
    public TextMeshProUGUI score;
    private void Update()
    {
        score.text = PlayerPrefs.GetInt("HighScore").ToString();
    }
}
