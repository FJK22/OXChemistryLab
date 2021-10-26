using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleDown : MonoBehaviour
{
    [Header("Min scale")]
    public Vector3 minScale;
    [Header("Max scale")]
    public Vector3 maxScale;
    [Header("Scaling Speed")]
    public float speed = 1f;
    public float duration = 10.0f;
    float timeLeft = 10.0f;

  

    IEnumerator Start()
    {
        maxScale = transform.localScale;

        if (timeLeft > 0)
        {
            yield return RepeatLerp(maxScale, minScale, duration);
            Debug.Log(transform.localScale);
        }
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;

    }



    public IEnumerator RepeatLerp(Vector3 a, Vector3 b, float time)
    {
        float i = 0.0f;
        float rate = (0.009127707f / time) * speed;

        while (i < 1.0f)
        {
            i += Time.deltaTime * rate;
            transform.localScale = Vector3.Lerp(a, b, i);
            yield return null; 
        }


    }
}
