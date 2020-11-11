using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public string moveRightBind, moveLeftBind, jumpBind, shootBind;
    public float moveSpeed = 0.7f;
    public Rigidbody2D rb;
    public Collider2D platforms;
    public bool dead = false;
    public float minY = .1f;
    // Update is called once per frame


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        if (!dead)
        {
            if (Input.GetKey(moveRightBind))
            {
                setMovement(1);
            }

            if (Input.GetKey(moveLeftBind))
            {
                setMovement(-1);
            }

            if (Input.GetKey(jumpBind))
            {
                jump();
            }

            if(rb.position.y < minY)
            {
                dead = true;
            }
        }
        if(dead)
        {
            SceneManager.LoadScene("You Died!", LoadSceneMode.Single);
        }
    }

    
    void setMovement(int magnitude)
    {
        var pos = transform.position;
        transform.position = new Vector2(pos.x + moveSpeed * magnitude, pos.y);

        GetComponent<SpriteRenderer>().flipX =  magnitude < 0;
    }

    void jump()
    {
        if (rb.IsTouching(platforms))
            rb.velocity = new Vector2(0, 3);
        
            
    }

    void shoot()
    {

    }

}
