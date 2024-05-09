
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotationSpeed = 100.0f;

    void Update()
    {
        if (Input.GetKey("w"))
        {
            Debug.Log("Moving Forward");
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            Debug.Log("Moving Backward");
            transform.Translate(-Vector3.forward * speed * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            transform.Rotate(-Vector3.up * rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey("space"))
        {
           transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
    }
}

