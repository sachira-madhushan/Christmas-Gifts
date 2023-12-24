using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Krampus : MonoBehaviour
{
    public GameObject leftKrampus, rightKrampus;
    public BallLaunch ballLaunch;
    float inTime = 0;
    float outTime = 0;
    float krampusTime = 0;
    int krampusCode = 0;
    bool outed = true;
    bool getBreak = false;
    private AudioSource audio;
    void Start()
    {
        audio = GetComponent<AudioSource>();
        
    }

    
    void Update()
    {
        
        krampusTime += Time.deltaTime;
        if (krampusTime > 40)
        {
            
            if (krampusCode == 0)
            {
                krampusCode = 1;
            }
            else if (krampusCode == 1)
            {
                krampusCode = 0;
            }
            krampusTime = 0;
            getBreak = false;
            
        }
        if (getBreak) return;
        inTime += Time.deltaTime;
        outTime += Time.deltaTime;
        if (inTime > 10 && outed)
        {
            if (krampusCode == 0)
            {
                leftKrampus.transform.position = new Vector3(leftKrampus.transform.position.x+5,leftKrampus.transform.position.y);
            }
            else if (krampusCode == 1)
            {
                rightKrampus.transform.position = new Vector3(rightKrampus.transform.position.x - 5, rightKrampus.transform.position.y);
            }
            audio.Play();
            inTime = 0;
            outed = false;
            ballLaunch.LaunchBall();
        }
        else if (outTime > 20)
        {
            if (krampusCode == 0)
            {
                leftKrampus.transform.position = new Vector3(leftKrampus.transform.position.x - 5, leftKrampus.transform.position.y);
            }
            else if (krampusCode == 1)
            {
                rightKrampus.transform.position = new Vector3(rightKrampus.transform.position.x + 5, rightKrampus.transform.position.y);
            }
            
            outTime = 0;
            outed = true;
            getBreak = true;
            ballLaunch.DontLaunchBall();
        }

        
        
    }
}
