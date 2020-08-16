using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public float balloonSpeed;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D> ();
       
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveUp()
    {
        rb.velocity = new Vector2(-balloonSpeed,0);
    }

    public void MoveDown()
    {
        rb.velocity = new Vector2(balloonSpeed,0);
    }

    public void SetVelocityZero()
    {
        rb.velocity = Vector2.zero;
    }
}
