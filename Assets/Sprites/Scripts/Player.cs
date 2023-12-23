using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed = 10;
    bool touching = true;
    public void MoveLeft()
    {
        touching = true;
        while (touching)
        {
            transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y);
        }
    }

    public void MoveRight()
    {
        touching = true;
        while (touching)
        {
            transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y);
        }
        
    }

    public void PointerUp()
    {
        touching = false;
    }


}
