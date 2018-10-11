using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class Oscillator : MonoBehaviour {

    [SerializeField] Vector3 movementVector = new Vector3(10f,10f,10f);
    [SerializeField] float period = 2;
    float movementFactor;

    Vector3 startingPos;

    // Use this for initialization
    void Start () {
        startingPos = transform.position;

	}
	
	// Update is called once per frame
	void Update () {

        float cycles = Time.time / period; // grows continually from 0

        const float tau = Mathf.PI * 2;
        float rawSignWave = Mathf.Sin(cycles * tau);
        print(rawSignWave);

        movementFactor = rawSignWave / 2f + 0.5f;
        Vector3 offset = movementFactor * movementVector;
        transform.position = startingPos + offset; 

	}
}
