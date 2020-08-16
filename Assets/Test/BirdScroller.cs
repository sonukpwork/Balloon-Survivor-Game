using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScroller : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float endPoint;
    Vector3 startPos;
    public bool shoudMove = true;
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (shoudMove)
        {
            transform.Translate((new Vector3(-1, 0, 0)) * speed * Time.deltaTime);
        }

        if (transform.position.x < endPoint)
        {
            shoudMove = false;
        }
    }
}
