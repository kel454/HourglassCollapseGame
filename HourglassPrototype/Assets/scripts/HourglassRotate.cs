using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HourglassRotate : MonoBehaviour {

    float correctRotation;
    bool stopRotation;

    // occurs after animation
    void LateUpdate()
    {
        // set the correct rotation when the stopRotation has been set by animation event
        if (stopRotation)
        {
            correctRotation = transform.eulerAngles.z;
            stopRotation = false; // unset so this only calls at the animation event
        }

        // set rotation each frame to the correct rotation
        transform.localRotation = Quaternion.Euler(0, 0, correctRotation);
    }

    // called by animation event
    public void StopRotation()
    {
        stopRotation = true;
    }
}
