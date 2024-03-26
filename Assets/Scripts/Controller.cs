using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float moveSpeed = 8.0f;

    public GameObject missilePrefab;
    public GameObject spawnPosition;
    public Transform[] spawnPositions;

    private void Awake()
    {
        spawnPositions = spawnPosition.GetComponentsInChildren<Transform>();
    }


    // Axis, joystick
    // Button Down, Up downing
    void Update()
    {
        float v = Input.GetAxisRaw("Vertical");
        float h = Input.GetAxisRaw("Horizontal");
        transform.Translate(v * Vector3.up * moveSpeed * Time.deltaTime);
        transform.Rotate(-h * Vector3.forward * 50 * Time.deltaTime);

        if (Input.GetButtonDown("Fire1"))
        {
            foreach(Transform t in spawnPositions)  // 부모 안의 자식 오브젝트 탐색
            {
                GameObject newGameObject = Instantiate(missilePrefab);
                newGameObject.transform.position = t.position;
                newGameObject.transform.rotation = t.rotation;
            }
        }

    }
}
