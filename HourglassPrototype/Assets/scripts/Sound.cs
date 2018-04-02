using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CLIPS {  GLASSBREAK }

public class Sound : MonoBehaviour {

   public  Dictionary<CLIPS, AudioClip> audioDictionary;
    AudioSource audioSource;
    bool play;

	// Use this for initialization
	void Start () {

        audioDictionary.Add(CLIPS.GLASSBREAK, Resources.Load<AudioClip>("Audio/GlassBreak"));

        //ps = GetComponent<GameObject>;
        play = false;
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(audioDictionary[CLIPS.GLASSBREAK]);
        // ps.Stop();

    }
	
	// Update is called once per frame
	void Update () {

       // play = !play;

       // audioSource.PlayOneShot(audioDictionary[CLIPS.GLASSBREAK]);
		
	}
}
