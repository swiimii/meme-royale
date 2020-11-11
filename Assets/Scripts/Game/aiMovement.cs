using UnityEngine;
using System.Collections;

public class aiMovement : MonoBehaviour {
    public Transform target;
    public float moveSpeed;
    public int rotationSpeed;
    public bool dead = false;
    public Collider2D danger;
    public GameObject player;

    private Collider2D playerHitbox;
    private Rigidbody2D rb;
    private Transform myTransform;

    // Use this for initialization
    void Awake() {
        myTransform = transform;
        rb = GetComponent<Rigidbody2D>();
        playerHitbox = player.GetComponent<Collider2D>();
        
    }

    void Start() {
        //GameObject go = GameObject.FindGameObjectWithTag("Player");

        //target = go.transform;
    }

    // Update is called once per frame
    void Update() {
        if (!dead)
        {
            Vector2 dir = target.position - myTransform.position;
            dir.y = 0.0f;
            if (dir != Vector2.zero)
            {
                myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.FromToRotation(Vector2.right, dir), rotationSpeed * Time.deltaTime);
            }

            //Move Towards Target
            myTransform.position += (target.position - myTransform.position).normalized * moveSpeed * Time.deltaTime;

            if (rb.IsTouching(danger))
            {
                dead = true;
            }

            if(rb.IsTouching(playerHitbox))
            {
                player.GetComponent<PlayerController>().dead = true;
            }
        }
        
    }
}