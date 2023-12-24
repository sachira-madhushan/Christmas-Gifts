using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchCount : MonoBehaviour
{
    int count = 0;
    public AudioClip santa, krampus;
    AudioSource audio;
    bool krampusSound = true;
    bool santaSound = true;
    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Input.touchCount > 0)
        {
            for (int i = 0; i < Input.touchCount; i++)
            {
                
                Touch touch = Input.GetTouch(i);

                if (touch.phase == TouchPhase.Ended)
                {

                    count++;
                }

            }
        }

        if (count >= 3 && krampusSound)
        {

            audio.clip = krampus;
            audio.Play();
            krampusSound = false;
        }
        if (count >= 5 && santaSound)
        {

            audio.clip = santa;
            audio.Play();
            santaSound = false;
        }
    }
}
