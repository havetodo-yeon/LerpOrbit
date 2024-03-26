using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpSample : MonoBehaviour
{
    public Transform a;
    public Transform b;

    // public float a = 0;
    // public float b = 1;

    public float t = 0;

    private float elapsedTime = 0;
    private float sign = +1;

    public MeshRenderer meshRenderer;

    public Color aColor;
    public Color bColor;

    public AnimationCurve curve;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        // Debug.Log(Mathf.Lerp(a, b, t));
        // Debug.Log(Vector3.Lerp(a.position, b.position, t));

        elapsedTime += sign * Time.deltaTime / 3.0f;   // 3 나눠서 3초만에 가도록

        if (elapsedTime <= 0 || elapsedTime >= 1)
        {
            sign *= -1;
        }

        transform.position = Vector3.Lerp(a.position, b.position, curve.Evaluate(elapsedTime));
        transform.rotation = Quaternion.Slerp(a.rotation, b.rotation, curve.Evaluate(elapsedTime));
        transform.localScale = Vector3.Lerp(a.localScale, b.localScale, curve.Evaluate(elapsedTime));

        Color targetColor = Color.Lerp(aColor, bColor, curve.Evaluate(elapsedTime));

        meshRenderer.sharedMaterial.SetColor("_Color", targetColor);
    }
}
