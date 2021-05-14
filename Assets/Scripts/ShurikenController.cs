using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShurikenController : MonoBehaviour
{
    public float velocityX = 10f;
    private Rigidbody2D rb;
    private PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerController = FindObjectOfType<PlayerController>();
        
        Destroy(gameObject, 4);


    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector2.right * velocityX;
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
           Destroy(other.gameObject);
            Destroy(this.gameObject);
            playerController.IncrementerPuntajeEn10();
          
        }
    }

}
