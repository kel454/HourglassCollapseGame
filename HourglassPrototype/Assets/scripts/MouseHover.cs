using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MouseHover : MonoBehaviour
    , IPointerEnterHandler
     , IPointerExitHandler
{ 


    private Button button;
    private Image image;
    // Use this for initialization
    void Start()
    {
        image = GetComponent<Image>();
        button = GetComponent<Button>();
        image.color = Color.white;
        //button.colors.normalColor = Color.black;
    }

   // void OnMouseEnter()
   // {
     //   GetComponent<Renderer>().material.color = Color.red;
    //}

    //void OnMouseExit()
    //{
      //  GetComponent<Renderer>().material.color = Color.black;
    //}

    public void OnPointerExit(PointerEventData eventData)
    {
        image.color = Color.white;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        image.color = Color.black;
    }
}