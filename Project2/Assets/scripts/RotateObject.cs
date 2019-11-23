using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    //This will adjust the rotation speed.
    public float rotationSpeed = 200.0f;

    // Update is called once per frame
    void Update()
    {
        //This rotates an object on its Y axis
        transform.Rotate(new Vector3(0, 1, 0), rotationSpeed * Time.deltaTime);
    }
}
