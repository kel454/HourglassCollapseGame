using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageAppear : MonoBehaviour {

    public GameObject Two;
    public GameObject Three;
    public GameObject Four;
    public GameObject Five;
    public GameObject Six;

    void Start () {
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        Six.gameObject.SetActive(false);
    }

    public void showTwo()
    {
        Two.gameObject.SetActive(true);
    }

    public void showThree()
    {
        Three.gameObject.SetActive(true);
    }

    public void showFour()
    {
        Four.gameObject.SetActive(true);
    }

    public void showFive()
    {
        Five.gameObject.SetActive(true);
    }

    public void showSix()
    {
        Six.gameObject.SetActive(true);
    }
}
