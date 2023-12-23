using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropGift : MonoBehaviour
{
    public GameObject[] Gifts;
    float timer = 0;
    void Start()
    {
        
    }

    
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 2)
        {
            float randomXPosition=Random.Range(-10.51f, 10.51f);
            int randomGift=Random.Range(0,3);
            Instantiate(Gifts[randomGift],new Vector3(randomXPosition,this.transform.position.y),Quaternion.identity);
            timer = 0;
        }
    }
}
