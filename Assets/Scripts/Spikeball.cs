using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikeball : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        transform.Rotate( new Vector3(0, 0, 4));
    }
}
