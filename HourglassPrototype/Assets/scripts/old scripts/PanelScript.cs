using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelScript : MonoBehaviour {

    public GameObject Panel;
    public GameObject hiddenButton;
    public GameObject Two;

    public int counter;

    private void Start()
    {
        Panel.gameObject.SetActive(false);
        hiddenButton.gameObject.SetActive(false);
        Two.gameObject.SetActive(false);

    }

    public void showPanel()
    {
        counter++;
        if (counter % 2 == 1) {
            Two.gameObject.SetActive(true);
        }
        else
        {
            Two.gameObject.SetActive(false);
        }
        if (counter % 2 == 2)
        {
            Panel.gameObject.SetActive(true);
        }
        else
        {
            Panel.gameObject.SetActive(false);
        }
    }
   
}
