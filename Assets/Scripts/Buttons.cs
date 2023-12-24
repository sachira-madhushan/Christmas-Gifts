using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Buttons : MonoBehaviour
{
    public GameObject pauseWindow;
    private void Start()
    {
        pauseWindow.SetActive(false);
    }
    public void Replay()
    {
        SceneManager.LoadScene("Game");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Home");
        }
    }
    public void Pause()
    {
        pauseWindow.SetActive(true);
        Time.timeScale = 0;
    }

    public void Resume()
    {
        pauseWindow.SetActive(false);
        Time.timeScale = 1;
    }
}
