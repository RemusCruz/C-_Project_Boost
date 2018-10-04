using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        ProcessInput();
	}

    private void ProcessInput()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            print("Space Pressed");
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            print("Right Arrow Pressed");
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            print("Left Arrow Key Pressed");
        }
    }
}
