using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Player : MonoBehaviour
{
    private float speed = 5;
    bool touching = true;
    bool leftPressed = false;
    bool rightPressed = false;
    private SpriteRenderer renderer;
    private Animator animator;
    public TextMeshProUGUI scoreText;
    public GameObject[] health;
    int healthCount = 0;
    int score = 0;
    private void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }
    private void FixedUpdate()
    {

        if (healthCount >= 5)
        {
            Time.timeScale = 0;
            print("Win");
        }
        if (leftPressed)
        {
            transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y);
            animator.SetBool("Walking",true);
        }else if (rightPressed)
        {
            transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y);
            animator.SetBool("Walking", true);
        }
    }
    public void MoveLeft()
    {
        leftPressed = true;
        renderer.flipX = true;
    }

    public void MoveRight()
    {
        rightPressed = true;
        renderer.flipX = false;
    }
    public void PointerUp()
    {
        leftPressed = false;
        rightPressed = false;
        animator.SetBool("Walking", false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Gift")
        {
            Destroy(collision.gameObject);
            score++;
            scoreText.text = score.ToString();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            health[healthCount].SetActive(false);
            healthCount++;
            
        }
    }


}
