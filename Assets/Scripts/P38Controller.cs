using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P38Controller : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    public float rotationSpeed = 60.0f;

    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        float v = Input.GetAxis("Vertical");    // Pitch, X
        float h = Input.GetAxis("Horizontal");  // Roll , Z

        transform.Rotate(new Vector3(v, 0, -h) * rotationSpeed * Time.deltaTime);

    }

}
