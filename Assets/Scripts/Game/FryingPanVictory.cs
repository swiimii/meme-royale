using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FryingPanVictory : MonoBehaviour {

    public GameObject player;

    private Rigidbody2D rb;
    private Collider2D playerHitbox;
	void Start ()
    {
        playerHitbox = player.GetComponent<Collider2D>();
        rb = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(rb.IsTouching(playerHitbox))
        {
            SceneManager.LoadScene("You Win!", LoadSceneMode.Single);
        }
	}
}
