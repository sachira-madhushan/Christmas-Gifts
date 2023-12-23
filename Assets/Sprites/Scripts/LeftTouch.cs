using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftTouch : MonoBehaviour
{
    private float speed = 10;
    public GameObject player;
    void Update()
    {
        Touch[] touch = Input.touches;
        for (int i = 0; i < Input.touchCount; i++)
        {
            Touch t = touch[i];
            if (t.deltaTime > 0.2f)
            {
                player.transform.position = new Vector3(player.transform.position.x - speed * Time.deltaTime, player.transform.position.y);
            }
        }
    }
}
