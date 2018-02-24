using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

    public float rotateSpeed = 5.0f;

    void FixedUpdate()
    {
        float move = Input.GetAxis("Mouse X");

        if (move < 0 || move > 0) transform.Rotate(Vector3.forward * rotateSpeed);
    }
}
