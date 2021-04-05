using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollScriptFloor : MonoBehaviour
{
    float scrollSpeed = -7f;
    Vector2 startPos;

    void Start()
    {
        startPos = new Vector2(-38, 0.5f);
    }

    void Update()
    {
        float newPos = Mathf.Repeat(Time.time * scrollSpeed, 38);
        transform.position = startPos + Vector2.right * newPos;
    }
}
