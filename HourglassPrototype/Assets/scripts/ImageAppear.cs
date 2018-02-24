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
    public GameObject Seven;
    public GameObject Eight;
    public GameObject Nine;
    public GameObject Ten;
    public GameObject Eleven;
    public GameObject Twelve;
    public GameObject Thirteen;
    public GameObject Fourteen;
    public GameObject Fifteen;

    void Start () {
        Two.gameObject.SetActive(false);
        Three.gameObject.SetActive(false);
        Four.gameObject.SetActive(false);
        Five.gameObject.SetActive(false);
        Six.gameObject.SetActive(false);
        Seven.gameObject.SetActive(false);
        Eight.gameObject.SetActive(false);
        Nine.gameObject.SetActive(false);
        Ten.gameObject.SetActive(false);
        Eleven.gameObject.SetActive(false);
        Twelve.gameObject.SetActive(false);
        Thirteen.gameObject.SetActive(false);
        Fourteen.gameObject.SetActive(false);
        Fifteen.gameObject.SetActive(false);
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

    public void showSeven()
    {
        Seven.gameObject.SetActive(true);
    }

    public void showEight()
    {
        Eight.gameObject.SetActive(true);
    }

    public void showNine()
    {
        Nine.gameObject.SetActive(true);
    }

    public void showTen()
    {
        Ten.gameObject.SetActive(true);
    }

    public void showEleven()
    {
        Eleven.gameObject.SetActive(true);
    }

    public void showTwelve()
    {
        Twelve.gameObject.SetActive(true);
    }

    public void showThirteen()
    {
        Thirteen.gameObject.SetActive(true);
    }

    public void showFourteen()
    {
        Fourteen.gameObject.SetActive(true);
    }

    public void showFifteen()
    {
        Fifteen.gameObject.SetActive(true);
    }
}
