using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMov : MonoBehaviour
{
    Rigidbody2D rb2;
    public int harekethýzý = 250;
    
    public float yatayhareket;
    public GameObject GameOverScreenText;

    public void Awake()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }
    public void Update()
    {
       /* if (Input.GetKeyDown(KeyCode.Space))
        {
            isSpaced = true;
        }else
        {
            isSpaced = false;
        }

        if (isSpaced)
         {
             rb2.constraints = RigidbodyConstraints2D.FreezePositionY;
         } else if (Input.GetKeyUp(KeyCode.Space))
         {
             rb2.constraints = RigidbodyConstraints2D.None;
             transform.Translate(Input.GetAxis("Horizontal") * 5f * Vector2.right * Time.deltaTime);
         } else
         {
             transform.Translate(Input.GetAxis("Horizontal") * 5f * Vector2.right * Time.deltaTime);
         } */
        

        
       rb2.velocity = new Vector2(yatayhareket * harekethýzý * Time.deltaTime, rb2.velocity.y);

    }
    
    public void Sol()
    {
        yatayhareket = -1;
    }

    public void Sag()
    {
        yatayhareket = +1;
    }


    public void dur()
    {
        yatayhareket = 0;
    }

    public void Bosluk()
    {
        rb2.constraints = RigidbodyConstraints2D.FreezePositionY;
    }
    public void BoslukBýrak()
    {
        rb2.constraints = RigidbodyConstraints2D.None;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Engel")
        {
            Time.timeScale = 0;
            GameOverScreenText.SetActive(true);
        } else
        {
            Destroy(gameObject);
        }
    }
    
}
