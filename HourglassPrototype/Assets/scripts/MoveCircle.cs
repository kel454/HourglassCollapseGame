﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MoveCircle : MonoBehaviour {

    public string pieceStatus = "Idle";

    public GameObject One;

    public KeyCode placePiece;
    public string checkPlacement;

    public static int Pieces;

	// Use this for initialization
	void Start () {

        Pieces = 0;
        One.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void OnMouseDown()
    {
        pieceStatus = "pickedup";
        checkPlacement = "n";
    }

    void Update () {

        if (pieceStatus == "pickedup")
        {
            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = objPosition;
        }

        if(Input.GetKeyDown(placePiece))
        {
            checkPlacement = "y";
            Debug.Log("y");
        }

        if (Pieces == 4)
        {
            One.gameObject.SetActive(true);
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if ((other.gameObject.name == gameObject.name) && (checkPlacement == "y"))
        {
            Debug.Log("Is");
            other.GetComponent<CircleCollider2D>().enabled = false;
            GetComponent<CircleCollider2D>().enabled = false;
            transform.position = other.gameObject.transform.position;
            pieceStatus = "locked";
            checkPlacement = "n";
            Pieces++;
        }

    }

}