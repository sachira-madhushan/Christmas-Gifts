using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLaunch : MonoBehaviour
{
    public GameObject ball;
    public GameObject player;
    private AudioSource audio;
    float timer = 0;
    bool lanch = false;
    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (!lanch) return;
        timer += Time.deltaTime;
        if (timer > 2)
        {
            Instantiate(ball, new Vector3(player.transform.position.x, this.transform.position.y), Quaternion.identity);
            timer = 0;
            audio.Play();
        }
    }

    public void LaunchBall()
    {
        lanch = true;
    }
    public void DontLaunchBall()
    {
        lanch = false;
    }
}
