using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class BalloonController : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public float diry;
    public float balloonSpeed = 10f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        diry = CrossPlatformInputManager.GetAxis("Vertical") * balloonSpeed;
        rb.velocity = new Vector2(diry,0f);
    }
}
