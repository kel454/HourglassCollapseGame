using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// © 2017 TheFlyingKeyboard and released under MIT License
// theflyingkeyboard.net

public class Rotation2 : MonoBehaviour
{
    public float offset = 0.0f;
    public float rotateSpeed = 0.001f;

    public GameObject Changer;

    int Hits;

    bool MouseDown;
    // Use this for initialization
    void Start()
    {
        MouseDown = false;

        Changer.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (MouseDown)
        {
            Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            difference.Normalize();
            float rotation_z = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, 0f, rotation_z + offset);
        }

        if (Hits == 4)
        {
            Changer.gameObject.SetActive(true);
        }

        Debug.Log (Hits);
    }

    void OnMouseDown()
    {
        MouseDown = true;
    }

    void OnMouseUp()
    {
        MouseDown = false; 
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Hits++;
        Debug.Log("it is colliding");
    }

        }
