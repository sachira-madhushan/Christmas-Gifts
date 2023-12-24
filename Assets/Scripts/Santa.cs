using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Santa : MonoBehaviour
{
    public GameObject[] Gifts;
    public GameObject giftLocation;
    private SpriteRenderer renderer;
    float timer=0;
    float upTimeAndDownTime = 0;
    int direction = 0;
    float speed =1;
    bool upOrDown = false;
    private AudioSource audio;
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        audio = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        if (direction == 0)
        {
            transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y);
            renderer.flipX = false;
        }else if (direction == 1)
        {
            renderer.flipX = true;
            transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y);
        }
        upTimeAndDownTime += Time.deltaTime;
        timer += Time.deltaTime;
        if (timer > 4)
        {
            timer = 0;
            int randomGift = Random.Range(0, 3);

            Instantiate(Gifts[randomGift],giftLocation.transform.position,Quaternion.identity);
        }
        if (upTimeAndDownTime > 20)
        {
            audio.Play();
            upTimeAndDownTime = 0;
        }
        
        
    }

    void ChangePosition()
    {
        if (upOrDown)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 6);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 6);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "LeftBorder")
        {
            direction = 0;
        }
        else if (collision.gameObject.tag == "RightBorder")
        {
            direction = 1;
        }
    }
}
