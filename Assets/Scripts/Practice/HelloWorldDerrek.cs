using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorldDerrek : MonoBehaviour {

    public new string name = "Untitled";
    public bool alive;
    public int age = 10;
    public int[] points = new int[5];
    public string[] names;

    public float speed{
        get{
            return sm.speed;
        }
    }

    private SpeedManagerDerrek sm;

    private void Awake(){
        print("Awake");
        sm = gameObject.GetComponent<SpeedManagerDerrek>();
    }
    // Use this for initialization
    void Start () {
        print("Start " + PosUtilDerrek.CalculateIndex(5, 3, 10));
	}

    private void FixedUpdate() {

    }

    // Update is called once per frame
    void Update () {
        var pos = transform.position;

        transform.position = new Vector3(pos.x + speed, pos.y, pos.z);
	}

    private void LateUpdate() {
        
    }
}
