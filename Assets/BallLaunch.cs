using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLaunch : MonoBehaviour
{
    public GameObject ball;
    public GameObject player;
    float timer = 0;
    bool lanch = false;
    void Update()
    {
        if (!lanch) return;
        timer += Time.deltaTime;
        if (timer > 2)
        {
            Instantiate(ball, new Vector3(player.transform.position.x, this.transform.position.y), Quaternion.identity);
            timer = 0;
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
