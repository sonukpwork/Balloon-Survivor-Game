using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundries : MonoBehaviour
{
    private Vector2 screenBounds; // This is the screen size;
    public float playerWidth;
    public float playerHeight;
    void Start()
    {
        playerWidth = transform.localScale.x / -1.5f;
        playerHeight = transform.localScale.y / -0.90f;
        screenBounds = new Vector2(Camera.main.aspect * Camera.main.orthographicSize + playerWidth, Camera.main.orthographicSize + playerHeight);

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -screenBounds.x)
        {
            transform.position = new Vector2(-screenBounds.x, transform.position.y);
        }
        else if(transform.position.x > screenBounds.x)
        {
            transform.position = new Vector2(screenBounds.x, transform.position.y);
        }

        if(transform.position.y < -screenBounds.y)
        {
            transform.position = new Vector2(transform.position.x, -screenBounds.y);
        }

        else if(transform.position.y > screenBounds.y)
        {
            transform.position = new Vector2(transform.position.x, screenBounds.y);
        }
    }
}
