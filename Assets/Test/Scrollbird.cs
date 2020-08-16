using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrollbird : MonoBehaviour
{
    //private Rigidbody2D rb2d;
    public float scrollSpeed = 0.01f;
    public float TimeForScroll = 0;

    void Start()
    {
        //rb2d = GetComponent<Rigidbody2D>();
        //rb2d.velocity = new Vector2(-1.5f, 0);
    }
    // Update is called once per frame
    void Update()
    {
        //if (Player is moving)
        //{
        //    TimeForScroll += Time.DeltaTime;
        //}
        //Vector2 offset = new Vector2(TimeForScroll * scrollSpeed, 0);
        //GetComponent<Renderer>().material.mainTextureOffset = offset
    }
}
