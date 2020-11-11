using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorldSamPractice : MonoBehaviour
{

    public new string name = "Untitled";

    
    public bool alive;
    public int age = 10;
    public int[] points = new int[5];
    public string[] names;

    public float speed
    {
        get
        {
            return sm.speed;
        }
    }

    private SpeedManager sm;

    //Called before Start
    void Awake()
    {
        sm = gameObject.GetComponent<SpeedManager>();
    }
    // Use this for initialization
    void Start ()
    {
        print("Start " + PosUtil.CalculateIndex(5, 3, 10));
	}

    //Called at a fixed interval allowing for more accurate physics calculations 
    void FixedUpdate()
    {
        
    }

    // Update is called once per frame
    void Update ()
    {
        var pos = transform.position;
        pos = new Vector2(pos.x + speed, pos.y);
	}

    //Called after everything is updated
    void LateUpdate()
    {
        
    }
}
