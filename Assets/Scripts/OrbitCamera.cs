using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitCamera : MonoBehaviour
{

    void Start()
    {
        transform.position = GameObject.FindGameObjectWithTag("Player").transform.position;
    }


    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 rotationDir = new Vector3(v, h, 0) * 60.0f * Time.deltaTime;
        transform.Rotate(rotationDir);
    }
}
