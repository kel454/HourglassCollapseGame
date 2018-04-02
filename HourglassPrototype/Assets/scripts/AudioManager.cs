using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour {
    private static bool created = false;
    public static int scenenum;

    void Awake()
    {
        if (!created)
        {
            DontDestroyOnLoad(this.gameObject);
            created = true;
            Debug.Log("Awake: " + this.gameObject);
        }
    }

    void Update ()
    {
        if (SceneManager.GetActiveScene().name == "4_HC")
        {
            Destroy(this.gameObject);
        }
        else if (SceneManager.GetActiveScene().name == "8_HC")
        {
            Destroy(this.gameObject);
        }
    }

    public void LoadScene()
    {
        if (SceneManager.GetActiveScene().name == "scene1")
        {
            SceneManager.LoadScene("scene2", LoadSceneMode.Single);
        }
    }
}