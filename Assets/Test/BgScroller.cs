using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgScroller : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float endPoint;
    public GameObject pnl;
    Vector3 startPos;
    public static bool shoudMove = true;

   
    void Start()
    {
        shoudMove = true;
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
            pnl.SetActive(true);
            JoyStick.joysticActive = false;
        }
    }

}
