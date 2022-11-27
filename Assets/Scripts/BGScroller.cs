using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroller : MonoBehaviour
{
    private Renderer r;
    public float speed = 0.5f;
    private Vector2 offset;
    private void Awake()
    {
        r = GetComponent<Renderer>();
    }
    void Start()
    {
        
    }

    void Update()
    {
        offset = new Vector2(0f, Time.time * speed);
        r.material.mainTextureOffset = offset;
    }
}
