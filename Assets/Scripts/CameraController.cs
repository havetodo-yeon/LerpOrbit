using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [HideInInspector]
    public GameObject player;
    public float smoothTime = 0.05f;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void LateUpdate()
    {
        // 선형 보간법을 활용해 player보다 조금 느리게 가도록
        transform.position = Vector3.Lerp(transform.position, player.transform.position, Time.deltaTime * 3.0f);
        transform.rotation = Quaternion.Lerp(transform.rotation, player.transform.rotation, Time.deltaTime * 3.0f);

        // SmoothDamp 활용!!
        //Vector3 velocity = Vector3.zero;
        //transform.position = Vector3.SmoothDamp(transform.position, player.transform.position, ref velocity, smoothTime);
        //transform.rotation = Quaternion.Slerp(transform.rotation, player.transform.rotation, Time.deltaTime * 3.0f);

        // transform.position = player.transform.position;
        //transform.rotation = player.transform.rotation;

    }
}
