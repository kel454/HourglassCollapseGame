using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMaze : MonoBehaviour {

    public Transform mazeObj;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("w"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 100);
        }

        else

        if (Input.GetKey("s"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, -100);
        }

        else

        if (Input.GetKey("a"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-100, 0);
        }

        else

        if (Input.GetKey("d"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(100, 0);
        }

        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }

    }
}
