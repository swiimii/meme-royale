using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CloseGameWithEscape : MonoBehaviour {

	// Use this for initialization
	void Start ()
 {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKey("escape"))
        {
            //UnityEditor.EditorApplication.isPlaying = false;
            Application.Quit();
        }
        if(Input.GetKey("r"))
        {
            SceneManager.LoadScene("Level1", LoadSceneMode.Single);
        }
	}
}
