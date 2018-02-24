using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleEnd : MonoBehaviour {

    int pieces;
    public GameObject One;
    public GameObject Puzzle1;
    public GameObject Puzzle2;
    public GameObject Puzzle3;
    public GameObject Puzzle4;
    public GameObject Puzzle5;
    public GameObject Puzzle6;
    public GameObject Puzzle7;
    public GameObject Puzzle8;
    public GameObject Puzzle9;
    public GameObject Puzzle10;
    public GameObject Puzzle11;
    public GameObject Puzzle12;

    // Use this for initialization
    void Start () {
        pieces = 0;
        One.gameObject.SetActive(false);
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject == Puzzle1)
        {
            pieces++;
            Debug.Log("testing");
        }

        if (col.gameObject == Puzzle2)
        {
            pieces++;
        }

        if (col.gameObject == Puzzle3)
        {
            pieces++;
        }

        if (col.gameObject == Puzzle4)
        {
            pieces++;
            Debug.Log("testing");
        }

        if (col.gameObject == Puzzle5)
        {
            pieces++;
        }

        if (col.gameObject == Puzzle6)
        {
            pieces++;
            Debug.Log("testing");
        }

        if (col.gameObject == Puzzle7)
        {
            pieces++;
        }

        if (col.gameObject == Puzzle8)
        {
            pieces++;
        }

        if (col.gameObject == Puzzle9)
        {
            pieces++;
        }

        if (col.gameObject == Puzzle10)
        {
            pieces++;
            Debug.Log("testing");
        }

        if (col.gameObject == Puzzle11)
        {
            pieces++;
        }

        if (col.gameObject == Puzzle12)
        {
            pieces++;
        }
    }

    // Update is called once per frame
    void Update () {
        if(pieces == 12)
        {
            One.gameObject.SetActive(true);
        }
        Debug.Log(pieces);

    }
}
