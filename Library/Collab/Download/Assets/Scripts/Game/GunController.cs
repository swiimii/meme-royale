using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour {

    
    public float bulletSpeed;
    public int bulletDuration;
    public GameObject user;
    public Collider2D platforms;
    public Rigidbody2D rb;

    private int bulletCountDown;
    private bool isFiring;
    private float bulletOffsetX, bulletOffsetY;
    private int direction;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        bulletOffsetX = .273f - -0.064f;
        bulletOffsetY = 0.536f - 0.438f;
        isFiring = false;
        transform.position = new Vector2(-999, -999);

    }
	
	// Update is called once per frame
	void Update () {

        if(isFiring)
        {
            bulletCountDown--;
            var pos = transform.position;
            transform.position = new Vector2(pos.x + bulletSpeed * direction, pos.y);
            //move bullet in direction

        }
        if(bulletCountDown < 0)
        {
            transform.position = new Vector2(-999, -999);
            isFiring = false;
        }
		if(Input.GetKey(user.GetComponent<PlayerController>().shootBind))
        {
            if (isFiring == false)
            {
                isFiring = true;
                bulletCountDown = bulletDuration;
                direction = (user.GetComponent<SpriteRenderer>().flipX) ? -1 : 1 ;

                var userPosition = user.transform.position;
                //TODO Must change offset depending on direction
                transform.position = new Vector2(userPosition.x + bulletOffsetX*direction + bulletSpeed, userPosition.y + bulletOffsetY);
            }
        }

        if (rb.IsTouching(platforms))
        {
            var pos = transform.position;
            transform.position = new Vector2(pos.x + bulletSpeed * direction, pos.y);
            isFiring = false;

        }

	}
}
