using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelChoice : MonoBehaviour
{

    public void SceneChanger(string sceneChanger)
    {
        SceneManager.LoadScene(sceneChanger);
        Debug.Log("testing");
    }
}

