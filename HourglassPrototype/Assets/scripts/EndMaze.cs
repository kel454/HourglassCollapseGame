using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMaze : MonoBehaviour
{

    public GameObject End;

    // Use this for initialization
    void Start()
    {
        End.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D other)
    {
        End.gameObject.SetActive(true);
    }
}
