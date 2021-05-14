using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 50;
    public float upSpeed = 50;
    
    public GameObject rightShuriken;
    public GameObject leftShuriken;


    private SpriteRenderer sr;
    private Animator animator;
    private Rigidbody2D rb2d;
    
    private bool puedoSaltar = false;

    public Text scoreText;

    private int Score = 0;


    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>(); 
        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "PUNTAJE: " + Score;
        if (Input.GetKeyDown(KeyCode.A))
        {

            if (!sr.flipX)
            {
                var position = new Vector2(transform.position.x + 1.5f, transform.position.y - .5f);
                Instantiate(rightShuriken, position, rightShuriken.transform.rotation);
            }
            else
            {
                var position = new Vector2(transform.position.x - 2.5f, transform.position.y - .5f);
                Instantiate(leftShuriken, position, leftShuriken.transform.rotation);
            }
           
        }

        
        setIdleAnimation();
        
        if (Input.GetKey(KeyCode.C))
        {
            setSlideAnimation();
        }
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //setRunAnimation();
            rb2d.velocity = new Vector2(speed, rb2d.velocity.y);
            sr.flipX = false;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
           // setRunAnimation();
            rb2d.velocity = new Vector2(-speed, rb2d.velocity.y);
            sr.flipX = true;
        }
        else
        {
            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
        }
        
        
        if (Input.GetKeyDown(KeyCode.Space) && puedoSaltar)
        {
            rb2d.velocity = Vector2.up * upSpeed;
            puedoSaltar = false;
           
        }


    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.layer == 8)
            puedoSaltar = true;

    }



    private void setIdleAnimation()
    {
        animator.SetInteger("Estado", 0);
    }
    private void setRunAnimation()
    {
        animator.SetInteger("Estado", 1);
    }
    
    private void setSlideAnimation()
    {
        animator.SetInteger("Estado", 2);
    }
    
    private void setClimbAnimation()
    {
        animator.SetInteger("Estado", 3);
    }
    
    
    public void IncrementerPuntajeEn10()
    {
        Score += 10;
    }

   

}
