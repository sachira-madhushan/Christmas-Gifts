using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class HighScore : MonoBehaviour
{
    public TextMeshProUGUI highScore;
    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 000).ToString();
        Time.timeScale = 1;
    }

    public void playButton()
    {
        
        SceneManager.LoadScene("Christmas");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
